import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class WordBreakTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertTrue(self.solution().word_break("leetcode", ["leet", "code"]))

    def test_reuse(self) -> None:
        self.assertTrue(self.solution().word_break("applepenapple", ["apple", "pen"]))

    def test_impossible_suffix(self) -> None:
        self.assertFalse(self.solution().word_break("catsandog", ["cats", "dog", "sand", "and", "cat"]))

    def test_non_greedy_split(self) -> None:
        self.assertTrue(self.solution().word_break("aaaaaaa", ["aaaa", "aaa"]))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
