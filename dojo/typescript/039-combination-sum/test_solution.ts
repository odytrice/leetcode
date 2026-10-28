import { finish, rows, test } from "../shared.ts";
import { combinationSum } from "./solution.ts";
import { combinationSum as referenceCombinationSum } from "./reference_solution.ts";

const combinationSumImpl = process.argv.includes("--reference") ? referenceCombinationSum : combinationSum;

test("example", () => rows([[2, 2, 3], [7]], combinationSumImpl([2, 3, 6, 7], 7), true));
test("multiple combinations", () =>
  rows([[2, 2, 2, 2], [2, 3, 3], [3, 5]], combinationSumImpl([2, 3, 5], 8), true));
test("impossible", () => rows([], combinationSumImpl([2], 1), true));

// Add your own cases here.

finish();
