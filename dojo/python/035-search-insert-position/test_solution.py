import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class SearchInsertTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_found(self) -> None:
        self.assertEqual(self.solution().search_insert([1, 3, 5, 6], 5), 2)

    def test_between(self) -> None:
        self.assertEqual(self.solution().search_insert([1, 3, 5, 6], 2), 1)

    def test_after(self) -> None:
        self.assertEqual(self.solution().search_insert([1, 3, 5, 6], 7), 4)

    def test_before(self) -> None:
        self.assertEqual(self.solution().search_insert([1], 0), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
