import { finish, sequence, test } from "../shared.ts";
import { twoSum } from "./solution.ts";
import { twoSum as referenceTwoSum } from "./reference_solution.ts";

const twoSumImpl = process.argv.includes("--reference") ? referenceTwoSum : twoSum;

test("example", () => sequence([1, 2], twoSumImpl([2, 7, 11, 15], 9)));
test("negative", () => sequence([1, 3], twoSumImpl([-3, 0, 4], 1)));
test("duplicates", () => sequence([1, 2], twoSumImpl([2, 2], 4)));

// Add your own cases here.

finish();
