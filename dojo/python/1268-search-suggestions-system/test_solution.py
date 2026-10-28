import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class SuggestedProductsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_lexicographic_top_three(self) -> None:
        self.assertEqual(
            self.solution().suggested_products(["bags", "baggage", "banner", "box", "cloth"], "ba"),
            [["baggage", "bags", "banner"], ["baggage", "bags", "banner"]],
        )

    def test_missing_suffix(self) -> None:
        self.assertEqual(self.solution().suggested_products(["a"], "abc"), [["a"], [], []])

    def test_fewer_than_three(self) -> None:
        self.assertEqual(
            self.solution().suggested_products(["cat", "car"], "cat"),
            [["car", "cat"], ["car", "cat"], ["cat"]],
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
