import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class FindCircleNumTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().find_circle_num([[1, 1, 0], [1, 1, 0], [0, 0, 1]]), 2)

    def test_isolated(self) -> None:
        self.assertEqual(self.solution().find_circle_num([[1, 0, 0], [0, 1, 0], [0, 0, 1]]), 3)

    def test_transitive(self) -> None:
        self.assertEqual(self.solution().find_circle_num([[1, 1, 0], [1, 1, 1], [0, 1, 1]]), 1)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
