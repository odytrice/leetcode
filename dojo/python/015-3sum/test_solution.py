import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[int]]) -> list[list[int]]:
    return sorted(sorted(row) for row in rows)


class ThreeSumTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            canonical(self.solution().three_sum([-1, 0, 1, 2, -1, -4])),
            canonical([[-1, -1, 2], [-1, 0, 1]]),
        )

    def test_duplicates(self) -> None:
        self.assertEqual(canonical(self.solution().three_sum([0, 0, 0, 0])), canonical([[0, 0, 0]]))

    def test_no_answer(self) -> None:
        self.assertEqual(self.solution().three_sum([1, 2, 3]), [])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
