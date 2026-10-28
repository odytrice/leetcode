import { finish, sequence, test } from "../shared.ts";
import { searchRange } from "./solution.ts";
import { searchRange as referenceSearchRange } from "./reference_solution.ts";

const searchRangeImpl = process.argv.includes("--reference") ? referenceSearchRange : searchRange;

test("example", () => sequence([3, 4], searchRangeImpl([5, 7, 7, 8, 8, 10], 8)));
test("absent", () => sequence([-1, -1], searchRangeImpl([1, 3], 2)));
test("empty", () => sequence([-1, -1], searchRangeImpl([], 0)));
test("all equal", () => sequence([0, 2], searchRangeImpl([2, 2, 2], 2)));

// Add your own cases here.

finish();
