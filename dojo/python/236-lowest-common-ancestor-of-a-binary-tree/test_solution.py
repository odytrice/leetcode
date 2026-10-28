import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LowestCommonAncestorTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_different_subtrees(self) -> None:
        root = TreeNode.from_level_order([3, 5, 1])
        self.assertIs(self.solution().lowest_common_ancestor(root, root.left, root.right), root)

    def test_ancestor_is_target(self) -> None:
        root = TreeNode.from_level_order([3, 5, 1, 6, 2])
        self.assertIs(
            self.solution().lowest_common_ancestor(root, root.left, root.left.right),
            root.left,
        )

    def test_two_nodes(self) -> None:
        root = TreeNode.from_level_order([1, 2])
        self.assertIs(self.solution().lowest_common_ancestor(root, root, root.left), root)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
