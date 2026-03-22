import subprocess
import sys
import tempfile
from pathlib import Path

SUCCESS = "success"
ERROR = "error"
TIMEOUT_SECONDS = 5
CLASS_NAME = "Main"
JAVA_FILE = f"{CLASS_NAME}.java"


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
    print(SUCCESS if actual_output == expected_output else ERROR)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
