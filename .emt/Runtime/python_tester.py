import ast
import subprocess
import sys
from pathlib import Path

SUCCESS = "success"
ERROR = "error"
INVALID = "invalid test case"
TIMEOUT_SECONDS = 5


def normalize(text: str) -> str:
    return text.strip().replace("\r\n", "\n")


def run_code(code_file: Path) -> str:
    try:
        result = subprocess.run(
            [sys.executable, str(code_file)],
            capture_output=True,
            text=True,
            timeout=TIMEOUT_SECONDS,
        )
    except (subprocess.TimeoutExpired, OSError):
        return ERROR

    if result.returncode != 0 or result.stderr:
        return ERROR

    return normalize(result.stdout)


def read_expected(expected_file: Path) -> str:
    try:
        return normalize(expected_file.read_text())
    except OSError:
        return ERROR


def read_source(code_file: Path) -> str:
    try:
        return code_file.read_text()
    except OSError:
        return ""


def is_main_guard(test: ast.AST) -> bool:
    if not isinstance(test, ast.Compare):
        return False

    if not isinstance(test.left, ast.Name) or test.left.id != "__name__":
        return False

    if len(test.ops) != 1 or not isinstance(test.ops[0], ast.Eq):
        return False

    if len(test.comparators) != 1:
        return False

    comparator = test.comparators[0]
    return isinstance(comparator, ast.Constant) and comparator.value == "__main__"


def render_constant_expr(node: ast.AST):
    if isinstance(node, ast.Constant):
        return "" if node.value is None else str(node.value)

    if isinstance(node, ast.JoinedStr):
        parts: list[str] = []
        for value in node.values:
            if isinstance(value, ast.Constant):
                parts.append("" if value.value is None else str(value.value))
            else:
                return None
        return "".join(parts)

    if isinstance(node, ast.BinOp) and isinstance(node.op, ast.Add):
        left = render_constant_expr(node.left)
        right = render_constant_expr(node.right)
        if left is None or right is None:
            return None
        return left + right

    return None


def collect_printed_lines(statements: list[ast.stmt], printed_lines: list[str]) -> bool:
    for statement in statements:
        if isinstance(statement, ast.If) and is_main_guard(statement.test):
            if statement.orelse:
                return False
            if not collect_printed_lines(statement.body, printed_lines):
                return False
            continue

        if not isinstance(statement, ast.Expr):
            return False

        call = statement.value
        if not isinstance(call, ast.Call):
            return False

        if not isinstance(call.func, ast.Name) or call.func.id != "print":
            return False

        if call.keywords:
            return False

        rendered_args: list[str] = []
        for argument in call.args:
            rendered = render_constant_expr(argument)
            if rendered is None:
                return False
            rendered_args.append(rendered)

        printed_lines.append(" ".join(rendered_args))

    return True


def directly_prints_expected_output(source: str, expected_output: str) -> bool:
    try:
        tree = ast.parse(source)
    except SyntaxError:
        return False

    printed_lines: list[str] = []
    if not collect_printed_lines(tree.body, printed_lines):
        return False

    actual_printed_output = normalize("\n".join(printed_lines)) if printed_lines else ""
    return actual_printed_output == expected_output


def main() -> int:
    if len(sys.argv) != 3:
        print(ERROR)
        return 1

    code_file = Path(sys.argv[1]).resolve()
    expected_file = Path(sys.argv[2]).resolve()

    actual_output = run_code(code_file)
    expected_output = read_expected(expected_file)

    if actual_output == expected_output:
        source = read_source(code_file)
        print(INVALID if directly_prints_expected_output(source, expected_output) else SUCCESS)
    else:
        print(ERROR)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
