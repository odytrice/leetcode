import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class EquationsPossibleTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_contradiction(self) -> None:
        self.assertFalse(self.solution().equations_possible(["a==b", "b!=a"]))

    def test_transitive_and_reordered(self) -> None:
        self.assertFalse(self.solution().equations_possible(["a!=c", "a==b", "b==c"]))

    def test_consistent(self) -> None:
        self.assertTrue(self.solution().equations_possible(["a==b", "b!=c"]))

    def test_self_inequality(self) -> None:
        self.assertFalse(self.solution().equations_possible(["a!=a"]))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
