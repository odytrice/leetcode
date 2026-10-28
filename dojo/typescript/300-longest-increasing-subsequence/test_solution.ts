import { equal, finish, test } from "../shared.ts";
import { lengthOfLIS } from "./solution.ts";
import { lengthOfLIS as referenceLengthOfLIS } from "./reference_solution.ts";

const lengthOfLISImpl = process.argv.includes("--reference") ? referenceLengthOfLIS : lengthOfLIS;

test("example", () => equal(4, lengthOfLISImpl([10, 9, 2, 5, 3, 7, 101, 18])));
test("equal", () => equal(1, lengthOfLISImpl([7, 7, 7])));
test("decreasing", () => equal(1, lengthOfLISImpl([3, 2, 1])));
test("replace tails", () => equal(4, lengthOfLISImpl([0, 1, 0, 3, 2, 3])));

// Add your own cases here.

finish();
