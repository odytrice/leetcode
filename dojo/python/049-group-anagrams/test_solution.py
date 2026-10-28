import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(groups: list[list[str]]) -> list[list[str]]:
    return sorted(sorted(group) for group in groups)


class GroupAnagramsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            canonical(self.solution().group_anagrams(["eat", "tea", "tan", "ate", "nat", "bat"])),
            canonical([["eat", "tea", "ate"], ["tan", "nat"], ["bat"]]),
        )

    def test_empty_strings(self) -> None:
        self.assertEqual(canonical(self.solution().group_anagrams(["", ""])), canonical([["", ""]]))

    def test_letter_counts(self) -> None:
        self.assertEqual(
            canonical(self.solution().group_anagrams(["ab", "aab", "ba"])),
            canonical([["ab", "ba"], ["aab"]]),
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
