import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class CanCompleteCircuitTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().can_complete_circuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]), 3)

    def test_impossible(self) -> None:
        self.assertEqual(self.solution().can_complete_circuit([2, 3, 4], [3, 4, 3]), -1)

    def test_single(self) -> None:
        self.assertEqual(self.solution().can_complete_circuit([5], [5]), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
