import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ReplaceWordsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            self.solution().replace_words(["cat", "bat", "rat"], "the cattle was rattled by the battery"),
            "the cat was rat by the bat",
        )

    def test_shortest_root(self) -> None:
        self.assertEqual(self.solution().replace_words(["aaa", "a", "aa"], "aaaa aa b"), "a a b")

    def test_exact_and_absent(self) -> None:
        self.assertEqual(self.solution().replace_words(["cat"], "cat dog"), "cat dog")

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
