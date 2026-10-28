import sys
import unittest

from reference_solution import ReferenceSolution
from solution import MinStack

USE_REFERENCE = "--reference" in sys.argv


class MinStackTests(unittest.TestCase):
    def make(self) -> MinStack:
        return ReferenceSolution() if USE_REFERENCE else MinStack()

    def test_example(self) -> None:
        stack = self.make()
        stack.push(-2)
        stack.push(0)
        stack.push(-3)
        self.assertEqual(stack.get_min(), -3)
        stack.pop()
        self.assertEqual(stack.top(), 0)
        self.assertEqual(stack.get_min(), -2)

    def test_duplicate_minimum(self) -> None:
        stack = self.make()
        stack.push(1)
        stack.push(1)
        stack.pop()
        self.assertEqual(stack.get_min(), 1)

    def test_int_limits(self) -> None:
        stack = self.make()
        stack.push(-2**31)
        stack.push(2**31 - 1)
        self.assertEqual(stack.get_min(), -2**31)
        self.assertEqual(stack.top(), 2**31 - 1)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
