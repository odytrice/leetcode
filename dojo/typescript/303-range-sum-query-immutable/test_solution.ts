import { equal, finish, test } from "../shared.ts";
import { NumArray } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (nums: number[]): NumArray => (useReference ? new ReferenceSolution(nums) : new NumArray(nums));

test("queries", () => {
  const values = make([-2, 0, 3, -5, 2, -1]);
  equal(1, values.sumRange(0, 2));
  equal(-1, values.sumRange(2, 5));
  equal(-3, values.sumRange(0, 5));
});

test("single", () => equal(-5, make([-5]).sumRange(0, 0)));

test("repeated query", () => {
  const values = make([1, 2]);
  equal(3, values.sumRange(0, 1));
  equal(3, values.sumRange(0, 1));
});

// Add your own cases here.

finish();
