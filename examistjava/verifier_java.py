import subprocess
import os

JAVA_FILE = "Main.java"
CLASS_NAME = "Main"
CLASS_FILE = "Main.class"
EXPECTED_FILE = "output.txt"
RESULT_FILE = "result.txt"


def compile_java():
    try:
        result = subprocess.run(
            ["javac", JAVA_FILE],
            capture_output=True,
            text=True,
            timeout=5,
            cwd="."
        )

        if result.returncode != 0:
            return False

        return True

    except subprocess.TimeoutExpired:
        return False


def run_java():
    try:
        result = subprocess.run(
            ["java", CLASS_NAME],
            capture_output=True,
            text=True,
            timeout=5,
            cwd="."
        )

        if result.returncode != 0:
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
        f.write(status)


def cleanup():
    # 🔥 delete compiled class file
    if os.path.exists(CLASS_FILE):
        try:
            os.remove(CLASS_FILE)
        except:
            pass


def main():
    if not compile_java():
        write_result("FAIL")
        cleanup()
        return

    actual_output = run_java()
    expected_output = read_expected()

    if actual_output.strip() == expected_output.strip():
        write_result("PASS")
    else:
        write_result("FAIL")

    # 🔥 cleanup after execution
    cleanup()


if __name__ == "__main__":
    main()