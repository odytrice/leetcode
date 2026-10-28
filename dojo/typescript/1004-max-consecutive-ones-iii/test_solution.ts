import { equal, finish, test } from "../shared.ts";
import { longestOnes } from "./solution.ts";
import { longestOnes as referenceLongestOnes } from "./reference_solution.ts";

const longestOnesImpl = process.argv.includes("--reference") ? referenceLongestOnes : longestOnes;

test("example", () => equal(6, longestOnesImpl([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2)));
test("no flips", () => equal(2, longestOnesImpl([1, 1, 0, 1], 0)));
test("all zeros", () => equal(2, longestOnesImpl([0, 0, 0], 2)));

// Add your own cases here.

finish();
