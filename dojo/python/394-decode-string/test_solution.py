import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class DecodeStringTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_nested(self) -> None:
        self.assertEqual(self.solution().decode_string("3[a2[c]]"), "accaccacc")

    def test_adjacent(self) -> None:
        self.assertEqual(self.solution().decode_string("2[abc]3[cd]ef"), "abcabccdcdcdef")

    def test_multiple_digits(self) -> None:
        self.assertEqual(self.solution().decode_string("12[a]"), "a" * 12)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
