import { equal, finish, test } from "../shared.ts";
import { LRUCache } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (capacity: number): LRUCache =>
  useReference ? new ReferenceSolution(capacity) : new LRUCache(capacity);

test("eviction and access", () => {
  const cache = make(2);
  cache.put(1, 1);
  cache.put(2, 2);
  equal(1, cache.get(1));
  cache.put(3, 3);
  equal(-1, cache.get(2));
  cache.put(4, 4);
  equal(-1, cache.get(1));
  equal(3, cache.get(3));
  equal(4, cache.get(4));
});

test("update refreshes recency", () => {
  const cache = make(2);
  cache.put(1, 1);
  cache.put(2, 2);
  cache.put(1, 9);
  cache.put(3, 3);
  equal(9, cache.get(1));
  equal(-1, cache.get(2));
});

test("capacity one", () => {
  const cache = make(1);
  cache.put(1, 2);
  cache.put(2, 3);
  equal(-1, cache.get(1));
  equal(3, cache.get(2));
});

// Add your own cases here.

finish();
