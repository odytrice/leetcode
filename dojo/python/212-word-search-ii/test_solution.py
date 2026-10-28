import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class FindWordsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example_and_restored(self) -> None:
        board = [["a", "b"], ["c", "d"]]
        self.assertEqual(sorted(self.solution().find_words(board, ["ab", "ac", "ad"])), ["ab", "ac"])
        self.assertEqual(["".join(row) for row in board], ["ab", "cd"])

    def test_multiple_paths_one_result(self) -> None:
        self.assertEqual(sorted(self.solution().find_words([["a", "a"], ["a", "a"]], ["aa"])), ["aa"])

    def test_prefix_words_and_no_reuse(self) -> None:
        self.assertEqual(
            sorted(self.solution().find_words([["a", "b"]], ["a", "ab", "aba"])),
            ["a", "ab"],
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
