import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class FindOrderTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def verify(self, courses: int, edges: list[list[int]]) -> None:
        order = self.solution().find_order(courses, edges)
        self.assertEqual(sorted(order), list(range(courses)))
        positions = {course: index for index, course in enumerate(order)}
        for course, prerequisite in edges:
            self.assertLess(positions[prerequisite], positions[course])

    def test_diamond(self) -> None:
        self.verify(4, [[1, 0], [2, 0], [3, 1], [3, 2]])

    def test_cycle(self) -> None:
        self.assertEqual(self.solution().find_order(2, [[1, 0], [0, 1]]), [])

    def test_isolated_courses(self) -> None:
        self.verify(3, [])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
