import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class IsValidBstTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_valid(self) -> None:
        self.assertTrue(self.solution().is_valid_bst(TreeNode.from_level_order([2, 1, 3])))

    def test_ancestor_violation(self) -> None:
        self.assertFalse(self.solution().is_valid_bst(TreeNode.from_level_order([5, 1, 7, None, None, 4, 8])))

    def test_duplicate(self) -> None:
        self.assertFalse(self.solution().is_valid_bst(TreeNode.from_level_order([2, 2, 3])))

    def test_integer_limits(self) -> None:
        self.assertTrue(self.solution().is_valid_bst(TreeNode.from_level_order([0, -2**31, 2**31 - 1])))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
