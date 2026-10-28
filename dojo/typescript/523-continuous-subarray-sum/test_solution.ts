import { equal, finish, test } from "../shared.ts";
import { checkSubarraySum } from "./solution.ts";
import { checkSubarraySum as referenceCheckSubarraySum } from "./reference_solution.ts";

const checkSubarraySumImpl = process.argv.includes("--reference") ? referenceCheckSubarraySum : checkSubarraySum;

test("example", () => equal(true, checkSubarraySumImpl([23, 2, 4, 6, 7], 6)));
test("absent", () => equal(false, checkSubarraySumImpl([23, 2, 6, 4, 7], 13)));
test("too short", () => equal(false, checkSubarraySumImpl([6], 6)));
test("zero sum", () => equal(true, checkSubarraySumImpl([0, 0], 7)));

// Add your own cases here.

finish();
