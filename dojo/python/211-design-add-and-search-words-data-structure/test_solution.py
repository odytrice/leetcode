import sys
import unittest

from reference_solution import ReferenceSolution
from solution import WordDictionary

USE_REFERENCE = "--reference" in sys.argv


class WordDictionaryTests(unittest.TestCase):
    def make(self) -> WordDictionary:
        return ReferenceSolution() if USE_REFERENCE else WordDictionary()

    def test_wildcards(self) -> None:
        dictionary = self.make()
        for word in ("bad", "dad", "mad"):
            dictionary.add_word(word)
        self.assertTrue(dictionary.search(".ad"))
        self.assertTrue(dictionary.search("b.."))
        self.assertFalse(dictionary.search("pad"))

    def test_exact_length(self) -> None:
        dictionary = self.make()
        dictionary.add_word("abc")
        self.assertFalse(dictionary.search(".."))
        self.assertFalse(dictionary.search("abc."))
        self.assertFalse(dictionary.search("ab"))

    def test_branch_exploration(self) -> None:
        dictionary = self.make()
        dictionary.add_word("cat")
        dictionary.add_word("dog")
        self.assertTrue(dictionary.search(".og"))
        self.assertFalse(dictionary.search(".ox"))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
