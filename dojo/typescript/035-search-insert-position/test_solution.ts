import { equal, finish, test } from "../shared.ts";
import { searchInsert } from "./solution.ts";
import { searchInsert as referenceSearchInsert } from "./reference_solution.ts";

const searchInsertImpl = process.argv.includes("--reference") ? referenceSearchInsert : searchInsert;

test("found", () => equal(2, searchInsertImpl([1, 3, 5, 6], 5)));
test("between", () => equal(1, searchInsertImpl([1, 3, 5, 6], 2)));
test("after", () => equal(4, searchInsertImpl([1, 3, 5, 6], 7)));
test("before", () => equal(0, searchInsertImpl([1], 0)));

// Add your own cases here.

finish();
