import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class IsValidTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_nested(self) -> None:
        self.assertTrue(self.solution().is_valid("([]){}"))

    def test_crossed(self) -> None:
        self.assertFalse(self.solution().is_valid("([)]"))

    def test_unclosed(self) -> None:
        self.assertFalse(self.solution().is_valid("("))

    def test_unopened(self) -> None:
        self.assertFalse(self.solution().is_valid(")"))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
