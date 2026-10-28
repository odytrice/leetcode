import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class FindCheapestPriceTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_one_stop(self) -> None:
        flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]]
        self.assertEqual(self.solution().find_cheapest_price(3, flights, 0, 2, 1), 200)

    def test_no_stops(self) -> None:
        flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]]
        self.assertEqual(self.solution().find_cheapest_price(3, flights, 0, 2, 0), 500)

    def test_unreachable(self) -> None:
        self.assertEqual(self.solution().find_cheapest_price(3, [[0, 1, 100]], 0, 2, 2), -1)

    def test_cheaper_route_exceeds_stop_limit(self) -> None:
        flights = [[0, 1, 1], [1, 2, 1], [2, 3, 1], [0, 2, 5]]
        self.assertEqual(self.solution().find_cheapest_price(4, flights, 0, 3, 1), 6)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
