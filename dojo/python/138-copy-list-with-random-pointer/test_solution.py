import sys
import unittest

from reference_solution import ReferenceSolution
from solution import RandomNode, Solution

USE_REFERENCE = "--reference" in sys.argv


class CopyRandomListTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_cross_pointers_and_duplicate_values(self) -> None:
        first = RandomNode(7)
        second = RandomNode(7)
        first.next = second
        first.random = second
        second.random = first

        copy = self.solution().copy_random_list(first)
        self.assertIsNot(copy, first)
        self.assertIsNot(copy.next, second)
        self.assertEqual(copy.val, 7)
        self.assertEqual(copy.next.val, 7)
        self.assertIs(copy.random, copy.next)
        self.assertIs(copy.next.random, copy)
        self.assertIs(first.next, second)
        self.assertIs(second.random, first)

    def test_self_random(self) -> None:
        node = RandomNode(1)
        node.random = node
        copy = self.solution().copy_random_list(node)
        self.assertIsNot(copy, node)
        self.assertIs(copy.random, copy)
        self.assertIsNone(copy.next)

    def test_empty(self) -> None:
        self.assertIsNone(self.solution().copy_random_list(None))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
