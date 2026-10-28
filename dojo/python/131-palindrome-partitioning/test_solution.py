import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[str]]) -> list[tuple[str, ...]]:
    return sorted(tuple(row) for row in rows)


class PartitionTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            canonical(self.solution().partition("aab")),
            canonical([["a", "a", "b"], ["aa", "b"]]),
        )

    def test_single(self) -> None:
        self.assertEqual(canonical(self.solution().partition("a")), canonical([["a"]]))

    def test_whole_palindrome(self) -> None:
        self.assertEqual(
            canonical(self.solution().partition("aba")),
            canonical([["a", "b", "a"], ["aba"]]),
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
