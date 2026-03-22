import subprocess
import sys
from pathlib import Path

SUCCESS = "success"
ERROR = "error"
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


def main() -> int:
    if len(sys.argv) != 3:
        print(ERROR)
        return 1

    code_file = Path(sys.argv[1]).resolve()
    expected_file = Path(sys.argv[2]).resolve()

    actual_output = run_code(code_file)
    expected_output = read_expected(expected_file)

    print(SUCCESS if actual_output == expected_output else ERROR)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
