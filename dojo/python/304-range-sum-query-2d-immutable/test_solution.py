import sys
import unittest

from reference_solution import ReferenceSolution
from solution import NumMatrix

USE_REFERENCE = "--reference" in sys.argv


class NumMatrixTests(unittest.TestCase):
    def make(self, matrix: list[list[int]]) -> NumMatrix:
        return ReferenceSolution(matrix) if USE_REFERENCE else NumMatrix(matrix)

    def test_whole_rectangle(self) -> None:
        self.assertEqual(self.make([[1, 2], [3, 4]]).sum_region(0, 0, 1, 1), 10)

    def test_interior(self) -> None:
        self.assertEqual(self.make([[1, 2, 3], [4, 5, 6], [7, 8, 9]]).sum_region(2, 1, 2, 1), 8)

    def test_negatives(self) -> None:
        values = self.make([[-1, 2], [3, -4]])
        self.assertEqual(values.sum_region(1, 0, 1, 1), -1)
        self.assertEqual(values.sum_region(0, 0, 1, 1), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
