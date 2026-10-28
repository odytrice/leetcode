import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LengthOfLisTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().length_of_lis([10, 9, 2, 5, 3, 7, 101, 18]), 4)

    def test_equal(self) -> None:
        self.assertEqual(self.solution().length_of_lis([7, 7, 7]), 1)

    def test_decreasing(self) -> None:
        self.assertEqual(self.solution().length_of_lis([3, 2, 1]), 1)

    def test_replace_tails(self) -> None:
        self.assertEqual(self.solution().length_of_lis([0, 1, 0, 3, 2, 3]), 4)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
