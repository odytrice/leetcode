import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class PartitionLabelsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            self.solution().partition_labels("ababcbacadefegdehijhklij"),
            [9, 7, 8],
        )

    def test_one_part(self) -> None:
        self.assertEqual(self.solution().partition_labels("eccbbbbdec"), [10])

    def test_distinct(self) -> None:
        self.assertEqual(self.solution().partition_labels("abc"), [1, 1, 1])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
