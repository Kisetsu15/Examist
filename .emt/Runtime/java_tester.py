import re
import subprocess
import sys
import tempfile
from pathlib import Path

SUCCESS = "success"
ERROR = "error"
INVALID = "invalid test case"
TIMEOUT_SECONDS = 5
CLASS_NAME = "Main"
JAVA_FILE = f"{CLASS_NAME}.java"
PRINT_PATTERN = re.compile(r"System\.out\.print(?:ln)?\s*\((.*?)\)\s*;", re.DOTALL)
CONTROL_FLOW_PATTERN = re.compile(r"\b(if|for|while|switch|try|catch|finally|do)\b")
ASSIGNMENT_PATTERN = re.compile(r"(?<![=!<>])=(?!=)")
MAIN_WRAPPER_PATTERN = re.compile(
    r"public\s+class\s+\w+\s*\{\s*public\s+static\s+void\s+main\s*\(\s*String\s*\[\s*\]\s*\w+\s*\)\s*\{(.*)\}\s*\}\s*",
    re.DOTALL,
)


def normalize(text: str) -> str:
    return text.strip().replace("\r\n", "\n")


def compile_java(source_file: Path, build_dir: Path) -> bool:
    java_file = build_dir / JAVA_FILE
    java_file.write_text(source_file.read_text())

    try:
        result = subprocess.run(
            ["javac", JAVA_FILE],
            capture_output=True,
            text=True,
            timeout=TIMEOUT_SECONDS,
            cwd=build_dir,
        )
    except (subprocess.TimeoutExpired, OSError):
        return False

    return result.returncode == 0


def run_java(build_dir: Path) -> str:
    try:
        result = subprocess.run(
            ["java", CLASS_NAME],
            capture_output=True,
            text=True,
            timeout=TIMEOUT_SECONDS,
            cwd=build_dir,
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


def read_source(source_file: Path) -> str:
    try:
        return source_file.read_text()
    except OSError:
        return ""


def strip_comments(source: str) -> str:
    source = re.sub(r"//.*", "", source)
    return re.sub(r"/\*.*?\*/", "", source, flags=re.DOTALL)


def split_java_arguments(arguments_text: str) -> list[str]:
    arguments: list[str] = []
    current: list[str] = []
    in_string = False
    escape = False
    depth = 0

    for character in arguments_text:
        if in_string:
            current.append(character)
            if escape:
                escape = False
            elif character == "\\":
                escape = True
            elif character == '"':
                in_string = False
            continue

        if character == '"':
            in_string = True
            current.append(character)
        elif character == '(':
            depth += 1
            current.append(character)
        elif character == ')':
            depth = max(0, depth - 1)
            current.append(character)
        elif character == ',' and depth == 0:
            arguments.append("".join(current).strip())
            current = []
        else:
            current.append(character)

    tail = "".join(current).strip()
    if tail:
        arguments.append(tail)

    return arguments


def decode_java_string_literal(token: str):
    token = token.strip()
    if len(token) < 2 or not token.startswith('"') or not token.endswith('"'):
        return None

    inner = token[1:-1]
    try:
        return bytes(inner, "utf-8").decode("unicode_escape")
    except UnicodeDecodeError:
        return None


def render_java_expression(expression: str):
    pieces = [piece.strip() for piece in expression.split('+')]
    if not pieces or any(not piece for piece in pieces):
        return None

    rendered: list[str] = []
    for piece in pieces:
        decoded = decode_java_string_literal(piece)
        if decoded is None:
            return None
        rendered.append(decoded)

    return "".join(rendered)


def directly_prints_expected_output(source: str, expected_output: str) -> bool:
    cleaned_source = strip_comments(source)
    wrapper_match = MAIN_WRAPPER_PATTERN.fullmatch(cleaned_source.strip())
    if not wrapper_match:
        return False

    main_body = wrapper_match.group(1)
    if CONTROL_FLOW_PATTERN.search(main_body) or ASSIGNMENT_PATTERN.search(main_body):
        return False

    print_matches = list(PRINT_PATTERN.finditer(main_body))
    if not print_matches:
        return False

    body_without_prints = PRINT_PATTERN.sub("", main_body)
    body_without_prints = re.sub(r"[{};\s]", "", body_without_prints)
    if body_without_prints:
        return False

    printed_parts: list[str] = []
    for match in print_matches:
        arguments = split_java_arguments(match.group(1))
        rendered_arguments: list[str] = []
        for argument in arguments:
            rendered = render_java_expression(argument)
            if rendered is None:
                return False
            rendered_arguments.append(rendered)
        printed_parts.append(" ".join(rendered_arguments))

    actual_printed_output = normalize("\n".join(printed_parts))
    return actual_printed_output == expected_output


def main() -> int:
    if len(sys.argv) != 3:
        print(ERROR)
        return 1

    source_file = Path(sys.argv[1]).resolve()
    expected_file = Path(sys.argv[2]).resolve()

    try:
        with tempfile.TemporaryDirectory(prefix="examist_java_") as build_dir_name:
            build_dir = Path(build_dir_name)
            if not compile_java(source_file, build_dir):
                print(ERROR)
                return 0

            actual_output = run_java(build_dir)
    except OSError:
        print(ERROR)
        return 1

    expected_output = read_expected(expected_file)
    if actual_output == expected_output:
        source = read_source(source_file)
        print(INVALID if directly_prints_expected_output(source, expected_output) else SUCCESS)
    else:
        print(ERROR)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
