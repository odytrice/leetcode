import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class DailyTemperaturesTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            self.solution().daily_temperatures([73, 74, 75, 71, 69, 72, 76, 73]),
            [1, 1, 4, 2, 1, 1, 0, 0],
        )

    def test_increasing(self) -> None:
        self.assertEqual(self.solution().daily_temperatures([30, 40, 50, 60]), [1, 1, 1, 0])

    def test_equal_temperatures(self) -> None:
        self.assertEqual(self.solution().daily_temperatures([70, 70, 70]), [0, 0, 0])

    def test_decreasing(self) -> None:
        self.assertEqual(self.solution().daily_temperatures([90, 80, 70, 60]), [0, 0, 0, 0])

    def test_visual_walkthrough(self) -> None:
        self.assertEqual(self.solution().daily_temperatures([73, 71, 72, 74]), [3, 1, 1, 0])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
