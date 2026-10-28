import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LongestCommonSubsequenceTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().longest_common_subsequence("abcde", "ace"), 3)

    def test_disjoint(self) -> None:
        self.assertEqual(self.solution().longest_common_subsequence("abc", "def"), 0)

    def test_repeated_letters(self) -> None:
        self.assertEqual(self.solution().longest_common_subsequence("aaaa", "aa"), 2)

    def test_order_matters(self) -> None:
        self.assertEqual(self.solution().longest_common_subsequence("abc", "cba"), 1)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
