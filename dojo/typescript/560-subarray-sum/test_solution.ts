import { finish, equal, test } from "../shared.ts";
import { subarraySum } from "./solution.ts";
import { subarraySum as referenceSubarraySum } from "./reference_solution.ts";

const subarraySumImpl = process.argv.includes("--reference") ? referenceSubarraySum : subarraySum;

test("example one", () => equal(2, subarraySumImpl([1, 1, 1], 2)));
test("example two", () => equal(2, subarraySumImpl([1, 2, 3], 3)));
test("example three", () => equal(3, subarraySumImpl([1, -1, 0], 0)));
test("single match", () => equal(1, subarraySumImpl([3], 3)));
test("no match", () => equal(0, subarraySumImpl([2, 4, 6], 5)));

// Add your own cases here.

finish();
