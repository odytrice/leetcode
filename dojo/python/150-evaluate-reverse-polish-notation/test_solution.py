import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class EvalRpnTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().eval_rpn(["2", "1", "+", "3", "*"]), 9)

    def test_operand_order(self) -> None:
        self.assertEqual(self.solution().eval_rpn(["2", "3", "-"]), -1)

    def test_negative_division(self) -> None:
        self.assertEqual(self.solution().eval_rpn(["-7", "3", "/"]), -2)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
