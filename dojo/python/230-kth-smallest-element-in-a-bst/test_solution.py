import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class KthSmallestTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_minimum(self) -> None:
        root = TreeNode.from_level_order([3, 1, 4, None, 2])
        self.assertEqual(self.solution().kth_smallest(root, 1), 1)

    def test_interior(self) -> None:
        root = TreeNode.from_level_order([5, 3, 6, 2, 4, None, None, 1])
        self.assertEqual(self.solution().kth_smallest(root, 3), 3)

    def test_maximum(self) -> None:
        root = TreeNode.from_level_order([3, 1, 4, None, 2])
        self.assertEqual(self.solution().kth_smallest(root, 4), 4)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
