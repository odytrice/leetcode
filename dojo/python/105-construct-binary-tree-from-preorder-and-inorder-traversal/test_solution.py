import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def shape(node: TreeNode | None) -> str:
    if node is None:
        return "#"
    return f"{node.val}({shape(node.left)},{shape(node.right)})"


class BuildTreeTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        built = self.solution().build_tree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7])
        self.assertEqual(shape(built), shape(TreeNode.from_level_order([3, 9, 20, None, None, 15, 7])))

    def test_left_chain(self) -> None:
        self.assertEqual(shape(self.solution().build_tree([3, 2, 1], [1, 2, 3])), "3(2(1(#,#),#),#)")

    def test_single(self) -> None:
        self.assertEqual(shape(self.solution().build_tree([-1], [-1])), "-1(#,#)")

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
