import sys
import unittest

from reference_solution import ReferenceSolution
from solution import LRUCache

USE_REFERENCE = "--reference" in sys.argv


class LRUCacheTests(unittest.TestCase):
    def make(self, capacity: int) -> LRUCache:
        return ReferenceSolution(capacity) if USE_REFERENCE else LRUCache(capacity)

    def test_eviction_and_access(self) -> None:
        cache = self.make(2)
        cache.put(1, 1)
        cache.put(2, 2)
        self.assertEqual(cache.get(1), 1)
        cache.put(3, 3)
        self.assertEqual(cache.get(2), -1)
        cache.put(4, 4)
        self.assertEqual(cache.get(1), -1)
        self.assertEqual(cache.get(3), 3)
        self.assertEqual(cache.get(4), 4)

    def test_update_refreshes_recency(self) -> None:
        cache = self.make(2)
        cache.put(1, 1)
        cache.put(2, 2)
        cache.put(1, 9)
        cache.put(3, 3)
        self.assertEqual(cache.get(1), 9)
        self.assertEqual(cache.get(2), -1)

    def test_capacity_one(self) -> None:
        cache = self.make(1)
        cache.put(1, 2)
        cache.put(2, 3)
        self.assertEqual(cache.get(1), -1)
        self.assertEqual(cache.get(2), 3)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)
