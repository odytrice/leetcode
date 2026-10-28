import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class CanPartitionTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertTrue(self.solution().can_partition([1, 5, 11, 5]))

    def test_odd_sum(self) -> None:
        self.assertFalse(self.solution().can_partition([1, 2, 3, 5]))

    def test_no_element_reuse(self) -> None:
        self.assertFalse(self.solution().can_partition([1, 2, 5]))

    def test_equal_pair(self) -> None:
        self.assertTrue(self.solution().can_partition([100, 100]))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
