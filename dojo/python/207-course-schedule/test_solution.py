import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class CanFinishTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_possible(self) -> None:
        self.assertTrue(self.solution().can_finish(2, [[1, 0]]))

    def test_cycle(self) -> None:
        self.assertFalse(self.solution().can_finish(2, [[1, 0], [0, 1]]))

    def test_disconnected_cycle(self) -> None:
        self.assertFalse(self.solution().can_finish(4, [[1, 0], [2, 3], [3, 2]]))

    def test_no_edges(self) -> None:
        self.assertTrue(self.solution().can_finish(3, []))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
