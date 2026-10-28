import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class SortColorsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def verify(self, values: list[int], expected: list[int]) -> None:
        values = list(values)
        self.solution().sort_colors(values)
        self.assertEqual(values, expected)

    def test_example(self) -> None:
        self.verify([2, 0, 2, 1, 1, 0], [0, 0, 1, 1, 2, 2])

    def test_reverse(self) -> None:
        self.verify([2, 1, 0], [0, 1, 2])

    def test_single(self) -> None:
        self.verify([2], [2])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
