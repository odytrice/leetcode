import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class RightSideViewTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        root = TreeNode.from_level_order([1, 2, 3, None, 5, None, 4])
        self.assertEqual(self.solution().right_side_view(root), [1, 3, 4])

    def test_left_continues(self) -> None:
        self.assertEqual(self.solution().right_side_view(TreeNode.from_level_order([1, 2, 3, 4])), [1, 3, 4])

    def test_empty(self) -> None:
        self.assertEqual(self.solution().right_side_view(None), [])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
