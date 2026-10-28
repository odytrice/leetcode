import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class EventualSafeNodesTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        graph = [[1, 2], [2, 3], [5], [0], [5], [], []]
        self.assertEqual(self.solution().eventual_safe_nodes(graph), [2, 4, 5, 6])

    def test_self_loop(self) -> None:
        self.assertEqual(self.solution().eventual_safe_nodes([[0], []]), [1])

    def test_all_terminal(self) -> None:
        self.assertEqual(self.solution().eventual_safe_nodes([[], []]), [0, 1])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
