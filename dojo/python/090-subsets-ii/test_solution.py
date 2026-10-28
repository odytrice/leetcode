import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[int]]) -> list[tuple[int, ...]]:
    return sorted(tuple(sorted(row)) for row in rows)


class SubsetsWithDupTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            canonical(self.solution().subsets_with_dup([1, 2, 2])),
            canonical([[], [1], [2], [1, 2], [2, 2], [1, 2, 2]]),
        )

    def test_all_same(self) -> None:
        self.assertEqual(canonical(self.solution().subsets_with_dup([0, 0])), canonical([[], [0], [0, 0]]))

    def test_unsorted(self) -> None:
        self.assertEqual(canonical(self.solution().subsets_with_dup([2, -1])), canonical([[], [-1], [2], [-1, 2]]))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
