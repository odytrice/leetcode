import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ProductExceptSelfTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().product_except_self([1, 2, 3, 4]), [24, 12, 8, 6])

    def test_one_zero(self) -> None:
        self.assertEqual(self.solution().product_except_self([-1, 1, 0, -3, 3]), [0, 0, 9, 0, 0])

    def test_two_zeros(self) -> None:
        self.assertEqual(self.solution().product_except_self([0, 2, 0]), [0, 0, 0])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
