import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class DiameterTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        root = TreeNode.from_level_order([1, 2, 3, 4, 5])
        self.assertEqual(self.solution().diameter_of_binary_tree(root), 3)

    def test_single(self) -> None:
        self.assertEqual(self.solution().diameter_of_binary_tree(TreeNode(1)), 0)

    def test_below_root(self) -> None:
        root = TreeNode.from_level_order([1, 2, None, 3, 4, 5, None, None, 6])
        self.assertEqual(self.solution().diameter_of_binary_tree(root), 4)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
