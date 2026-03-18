import subprocess

CODE_FILE = "student_code.py"
EXPECTED_FILE = "expected_output.txt"
RESULT_FILE = "result.txt"


def run_code():
    try:
        result = subprocess.run(
            ["python", CODE_FILE],
            capture_output=True,
            text=True,
            timeout=5
        )

        if result.stderr:
            return "ERROR"

        return result.stdout.strip().replace("\r\n", "\n")

    except subprocess.TimeoutExpired:
        return "ERROR"


def read_expected():
    try:
        with open(EXPECTED_FILE, "r") as f:
            return f.read().strip().replace("\r\n", "\n")
    except:
        return "ERROR"


def write_result(status):
    with open(RESULT_FILE, "w") as f:
        f.write(status)   # ONLY PASS or FAIL


def main():
    actual_output = run_code()
    expected_output = read_expected()

    if actual_output == expected_output:
        write_result("PASS")
    else:
        write_result("FAIL")


if __name__ == "__main__":
    main()