import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class MinSubArrayLenTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().min_sub_array_len(7, [2, 3, 1, 2, 4, 3]), 2)

    def test_one_element(self) -> None:
        self.assertEqual(self.solution().min_sub_array_len(4, [1, 4, 4]), 1)

    def test_unreachable(self) -> None:
        self.assertEqual(self.solution().min_sub_array_len(11, [1, 1, 1, 1]), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
