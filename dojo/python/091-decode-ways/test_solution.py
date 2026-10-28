import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class NumDecodingsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().num_decodings("226"), 3)

    def test_leading_zero(self) -> None:
        self.assertEqual(self.solution().num_decodings("06"), 0)

    def test_valid_zeros(self) -> None:
        self.assertEqual(self.solution().num_decodings("1010"), 1)

    def test_invalid_zero(self) -> None:
        self.assertEqual(self.solution().num_decodings("100"), 0)

    def test_pair_too_large(self) -> None:
        self.assertEqual(self.solution().num_decodings("27"), 1)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
