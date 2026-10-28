import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[int]]) -> list[list[int]]:
    return sorted(sorted(row) for row in rows)


class KClosestTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(canonical(self.solution().k_closest([[1, 3], [-2, 2]], 1)), canonical([[-2, 2]]))

    def test_all_points(self) -> None:
        self.assertEqual(
            canonical(self.solution().k_closest([[1, 2], [3, 4]], 2)),
            canonical([[1, 2], [3, 4]]),
        )

    def test_duplicates(self) -> None:
        self.assertEqual(
            canonical(self.solution().k_closest([[0, 0], [0, 0], [1, 1]], 2)),
            canonical([[0, 0], [0, 0]]),
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
