import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[int]]) -> list[tuple[int, ...]]:
    return sorted(tuple(sorted(row)) for row in rows)


class SubsetsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_two_values(self) -> None:
        self.assertEqual(canonical(self.solution().subsets([1, 2])), canonical([[], [1], [2], [1, 2]]))

    def test_single(self) -> None:
        self.assertEqual(canonical(self.solution().subsets([0])), canonical([[], [0]]))

    def test_three_values(self) -> None:
        actual = self.solution().subsets([-1, 0, 1])
        self.assertEqual(len(actual), 8)
        self.assertEqual(len({tuple(sorted(row)) for row in actual}), 8)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
