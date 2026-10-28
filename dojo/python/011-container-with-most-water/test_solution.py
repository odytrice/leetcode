import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class MaxAreaTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().max_area([1, 8, 6, 2, 5, 4, 8, 3, 7]), 49)

    def test_two_lines(self) -> None:
        self.assertEqual(self.solution().max_area([1, 1]), 1)

    def test_zero_heights(self) -> None:
        self.assertEqual(self.solution().max_area([0, 0, 0]), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
