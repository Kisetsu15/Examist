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


def extract_string_literals(source: str) -> list[str]:
    try:
        tree = ast.parse(source)
    except SyntaxError:
        return []

    literals: list[str] = []
    for node in ast.walk(tree):
        if isinstance(node, ast.Constant) and isinstance(node.value, str):
            normalized_value = normalize(node.value)
            if normalized_value:
                literals.append(normalized_value)

    return literals


def prints_expected_output(source: str, expected_output: str) -> bool:
    expected_lines = [line.strip() for line in expected_output.split("\n") if line.strip()]
    if not expected_lines:
        return False

    string_literals = extract_string_literals(source)
    if not string_literals:
        return False

    return all(
        any(expected_line in literal for literal in string_literals)
        for expected_line in expected_lines
    )


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
        print(INVALID if prints_expected_output(source, expected_output) else SUCCESS)
    else:
        print(ERROR)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
