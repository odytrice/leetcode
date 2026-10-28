import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class MergeTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            self.solution().merge([[1, 3], [2, 6], [8, 10], [15, 18]]),
            [[1, 6], [8, 10], [15, 18]],
        )

    def test_touching_endpoints(self) -> None:
        self.assertEqual(sorted(map(tuple, self.solution().merge([[1, 4], [4, 5]]))), [(1, 5)])

    def test_unordered_and_contained(self) -> None:
        self.assertEqual(
            sorted(map(tuple, self.solution().merge([[8, 10], [1, 4], [2, 3]]))),
            [(1, 4), (8, 10)],
        )

    def test_contained_interval_must_not_shrink_end(self) -> None:
        self.assertEqual(sorted(map(tuple, self.solution().merge([[1, 10], [2, 3], [9, 12]]))), [(1, 12)])

    def test_zero_length_intervals(self) -> None:
        self.assertEqual(
            sorted(map(tuple, self.solution().merge([[3, 3], [1, 1], [3, 4]]))),
            [(1, 1), (3, 4)],
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
