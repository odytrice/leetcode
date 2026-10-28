import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LetterCombinationsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            sorted(self.solution().letter_combinations("23")),
            sorted(["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]),
        )

    def test_empty(self) -> None:
        self.assertEqual(self.solution().letter_combinations(""), [])

    def test_four_letter_digit(self) -> None:
        self.assertEqual(sorted(self.solution().letter_combinations("7")), ["p", "q", "r", "s"])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
