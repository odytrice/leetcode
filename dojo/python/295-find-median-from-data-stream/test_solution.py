import sys
import unittest

from reference_solution import ReferenceSolution
from solution import MedianFinder

USE_REFERENCE = "--reference" in sys.argv


class MedianFinderTests(unittest.TestCase):
    def make(self) -> MedianFinder:
        return ReferenceSolution() if USE_REFERENCE else MedianFinder()

    def test_example(self) -> None:
        finder = self.make()
        finder.add_num(1)
        finder.add_num(2)
        self.assertEqual(finder.find_median(), 1.5)
        finder.add_num(3)
        self.assertEqual(finder.find_median(), 2.0)

    def test_negative_values(self) -> None:
        finder = self.make()
        finder.add_num(-1)
        finder.add_num(-2)
        self.assertEqual(finder.find_median(), -1.5)
        finder.add_num(-3)
        self.assertEqual(finder.find_median(), -2.0)

    def test_duplicates(self) -> None:
        finder = self.make()
        for _ in range(8):
            finder.add_num(7)
            self.assertEqual(finder.find_median(), 7.0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
