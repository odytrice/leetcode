import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Trie

USE_REFERENCE = "--reference" in sys.argv


class TrieTests(unittest.TestCase):
    def make(self) -> Trie:
        return ReferenceSolution() if USE_REFERENCE else Trie()

    def test_word_versus_prefix(self) -> None:
        trie = self.make()
        trie.insert("apple")
        self.assertTrue(trie.search("apple"))
        self.assertFalse(trie.search("app"))
        self.assertTrue(trie.starts_with("app"))
        trie.insert("app")
        self.assertTrue(trie.search("app"))

    def test_missing_branch(self) -> None:
        trie = self.make()
        trie.insert("cat")
        self.assertFalse(trie.search("car"))
        self.assertFalse(trie.starts_with("z"))

    def test_duplicate_insert(self) -> None:
        trie = self.make()
        trie.insert("a")
        trie.insert("a")
        self.assertTrue(trie.search("a"))
        self.assertFalse(trie.search("aa"))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
