import sys
import unittest

from reference_solution import ReferenceSolution
from solution import StockSpanner

USE_REFERENCE = "--reference" in sys.argv


class StockSpannerTests(unittest.TestCase):
    def make(self) -> StockSpanner:
        return ReferenceSolution() if USE_REFERENCE else StockSpanner()

    def test_example(self) -> None:
        spanner = self.make()
        spans = [spanner.next(price) for price in [100, 80, 60, 70, 60, 75, 85]]
        self.assertEqual(spans, [1, 1, 1, 2, 1, 4, 6])

    def test_equal_prices(self) -> None:
        spanner = self.make()
        self.assertEqual(spanner.next(5), 1)
        self.assertEqual(spanner.next(5), 2)
        self.assertEqual(spanner.next(5), 3)

    def test_independent_instances(self) -> None:
        first = self.make()
        first.next(1)
        self.assertEqual(self.make().next(2), 1)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
