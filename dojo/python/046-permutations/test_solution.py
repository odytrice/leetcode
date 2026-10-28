import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[int]]) -> list[tuple[int, ...]]:
    return sorted(tuple(row) for row in rows)


class PermuteTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_two(self) -> None:
        self.assertEqual(canonical(self.solution().permute([1, 2])), canonical([[1, 2], [2, 1]]))

    def test_single(self) -> None:
        self.assertEqual(canonical(self.solution().permute([0])), canonical([[0]]))

    def test_three(self) -> None:
        actual = self.solution().permute([1, 2, 3])
        self.assertEqual(len(actual), 6)
        self.assertEqual(len({tuple(row) for row in actual}), 6)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
