import sys
import unittest

from reference_solution import ReferenceSolution
from solution import NumArray

USE_REFERENCE = "--reference" in sys.argv


class NumArrayTests(unittest.TestCase):
    def make(self, nums: list[int]) -> NumArray:
        return ReferenceSolution(nums) if USE_REFERENCE else NumArray(nums)

    def test_queries(self) -> None:
        values = self.make([-2, 0, 3, -5, 2, -1])
        self.assertEqual(values.sum_range(0, 2), 1)
        self.assertEqual(values.sum_range(2, 5), -1)
        self.assertEqual(values.sum_range(0, 5), -3)

    def test_single(self) -> None:
        self.assertEqual(self.make([-5]).sum_range(0, 0), -5)

    def test_repeated_query(self) -> None:
        values = self.make([1, 2])
        self.assertEqual(values.sum_range(0, 1), 3)
        self.assertEqual(values.sum_range(0, 1), 3)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
