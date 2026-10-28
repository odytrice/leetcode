import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LeastIntervalTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().least_interval(list("AAABBB"), 2), 8)

    def test_no_cooldown(self) -> None:
        self.assertEqual(self.solution().least_interval(list("AAABBB"), 0), 6)

    def test_single_type(self) -> None:
        self.assertEqual(self.solution().least_interval(list("AAA"), 2), 7)

    def test_enough_filler(self) -> None:
        self.assertEqual(self.solution().least_interval(list("ABCABC"), 1), 6)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
