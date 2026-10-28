import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class CanJumpTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_reachable(self) -> None:
        self.assertTrue(self.solution().can_jump([2, 3, 1, 1, 4]))

    def test_blocked(self) -> None:
        self.assertFalse(self.solution().can_jump([3, 2, 1, 0, 4]))

    def test_already_there(self) -> None:
        self.assertTrue(self.solution().can_jump([0]))

    def test_jump_over_zero(self) -> None:
        self.assertTrue(self.solution().can_jump([2, 0, 0]))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
