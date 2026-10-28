import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class UniquePathsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().unique_paths(3, 7), 28)

    def test_one_row(self) -> None:
        self.assertEqual(self.solution().unique_paths(1, 100), 1)

    def test_one_column(self) -> None:
        self.assertEqual(self.solution().unique_paths(100, 1), 1)

    def test_square(self) -> None:
        self.assertEqual(self.solution().unique_paths(3, 3), 6)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
