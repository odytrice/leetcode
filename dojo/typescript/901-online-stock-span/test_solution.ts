import { equal, finish, sequence, test } from "../shared.ts";
import { StockSpanner } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (): StockSpanner => (useReference ? new ReferenceSolution() : new StockSpanner());

test("example", () => {
  const spanner = make();
  sequence([1, 1, 1, 2, 1, 4, 6], [100, 80, 60, 70, 60, 75, 85].map((price) => spanner.next(price)));
});

test("equal prices", () => {
  const spanner = make();
  equal(1, spanner.next(5));
  equal(2, spanner.next(5));
  equal(3, spanner.next(5));
});

test("independent instances", () => {
  const first = make();
  first.next(1);
  equal(1, make().next(2));
});

// Add your own cases here.

finish();
