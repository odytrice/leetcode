import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LongestSubstringTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().length_of_longest_substring("abcabcbb"), 3)

    def test_repeated_character(self) -> None:
        self.assertEqual(self.solution().length_of_longest_substring("bbbbb"), 1)

    def test_window_end(self) -> None:
        self.assertEqual(self.solution().length_of_longest_substring("pwwkew"), 3)

    def test_empty(self) -> None:
        self.assertEqual(self.solution().length_of_longest_substring(""), 0)

    def test_previous_occurrence_outside_window(self) -> None:
        self.assertEqual(self.solution().length_of_longest_substring("abba"), 2)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
