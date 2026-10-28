import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class RobTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().rob([2, 7, 9, 3, 1]), 12)

    def test_skip_large_neighbor(self) -> None:
        self.assertEqual(self.solution().rob([2, 1, 1, 2]), 4)

    def test_single(self) -> None:
        self.assertEqual(self.solution().rob([5]), 5)

    def test_zeros(self) -> None:
        self.assertEqual(self.solution().rob([0, 0]), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
