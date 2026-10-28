import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def canonical(rows: list[list[str]]) -> list[list[str]]:
    return sorted(rows)


class AccountsMergeTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_transitive_merge(self) -> None:
        accounts = [["John", "a@x"], ["John", "b@x", "c@x"], ["John", "a@x", "b@x"]]
        self.assertEqual(canonical(self.solution().accounts_merge(accounts)),
                         canonical([["John", "a@x", "b@x", "c@x"]]))

    def test_same_name_distinct_people(self) -> None:
        accounts = [["John", "a@x"], ["John", "b@x"]]
        self.assertEqual(canonical(self.solution().accounts_merge(accounts)),
                         canonical([["John", "a@x"], ["John", "b@x"]]))

    def test_sorted_and_deduplicated(self) -> None:
        accounts = [["Mary", "z@x", "a@x", "z@x"]]
        self.assertEqual(self.solution().accounts_merge(accounts), [["Mary", "a@x", "z@x"]])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
