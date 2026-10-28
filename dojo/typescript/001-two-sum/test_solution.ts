import { finish, set, test } from "../shared.ts";
import { twoSum } from "./solution.ts";
import { twoSum as referenceTwoSum } from "./reference_solution.ts";

const twoSumImpl = process.argv.includes("--reference") ? referenceTwoSum : twoSum;

test("example", () => set([0, 1], twoSumImpl([2, 7, 11, 15], 9)));
test("duplicate values", () => set([0, 1], twoSumImpl([3, 3], 6)));
test("negative values", () => set([1, 2], twoSumImpl([4, -2, -3], -5)));

// Add your own cases here.

finish();
