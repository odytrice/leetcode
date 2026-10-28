import sys
import unittest

from reference_solution import ReferenceSolution
from solution import GraphNode, Solution

USE_REFERENCE = "--reference" in sys.argv


def visit(start: GraphNode) -> dict[int, GraphNode]:
    seen: dict[int, GraphNode] = {}
    queue = [start]
    while queue:
        node = queue.pop()
        if id(node) in seen:
            continue
        seen[id(node)] = node
        queue.extend(node.neighbors)
    return seen


class CloneGraphTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_cycle_and_shared_neighbors(self) -> None:
        originals = [GraphNode(value) for value in (1, 2, 3)]
        for node in originals:
            node.neighbors = [other for other in originals if other is not node]

        copy = self.solution().clone_graph(originals[0])
        nodes = visit(copy)
        self.assertEqual(len(nodes), 3)
        for node in nodes.values():
            self.assertNotIn(node, originals)
            self.assertEqual(sorted(neighbor.val for neighbor in node.neighbors),
                             sorted(neighbor.val for neighbor in originals[node.val - 1].neighbors))

    def test_isolated(self) -> None:
        node = GraphNode(1)
        copy = self.solution().clone_graph(node)
        self.assertIsNot(copy, node)
        self.assertEqual(copy.val, 1)
        self.assertEqual(copy.neighbors, [])

    def test_empty(self) -> None:
        self.assertIsNone(self.solution().clone_graph(None))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
