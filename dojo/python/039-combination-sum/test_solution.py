import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[int]]) -> list[tuple[int, ...]]:
    return sorted(tuple(sorted(row)) for row in rows)


class CombinationSumTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            canonical(self.solution().combination_sum([2, 3, 6, 7], 7)),
            canonical([[2, 2, 3], [7]]),
        )

    def test_multiple_combinations(self) -> None:
        self.assertEqual(
            canonical(self.solution().combination_sum([2, 3, 5], 8)),
            canonical([[2, 2, 2, 2], [2, 3, 3], [3, 5]]),
        )

    def test_impossible(self) -> None:
        self.assertEqual(self.solution().combination_sum([2], 1), [])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
