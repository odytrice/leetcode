import sys
import unittest

from reference_solution import ReferenceSolution
from solution import RandomizedSet

USE_REFERENCE = "--reference" in sys.argv


class RandomizedSetTests(unittest.TestCase):
    def make(self) -> RandomizedSet:
        return ReferenceSolution() if USE_REFERENCE else RandomizedSet()

    def test_insert_and_remove(self) -> None:
        values = self.make()
        self.assertTrue(values.insert(1))
        self.assertFalse(values.insert(1))
        self.assertFalse(values.remove(2))
        self.assertTrue(values.remove(1))
        self.assertFalse(values.remove(1))

    def test_swap_removal(self) -> None:
        values = self.make()
        values.insert(10)
        values.insert(20)
        values.insert(30)
        values.remove(20)
        self.assertTrue(values.remove(30))
        self.assertEqual(values.get_random(), 10)

    def test_random_membership(self) -> None:
        values = self.make()
        values.insert(-1)
        values.insert(2)
        values.insert(3)
        values.remove(2)
        for _ in range(200):
            self.assertIn(values.get_random(), (-1, 3))

    def test_reinsert(self) -> None:
        values = self.make()
        values.insert(7)
        values.remove(7)
        self.assertTrue(values.insert(7))
        self.assertEqual(values.get_random(), 7)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
