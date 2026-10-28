import { equal, finish, test } from "../shared.ts";
import { maxArea } from "./solution.ts";
import { maxArea as referenceMaxArea } from "./reference_solution.ts";

const maxAreaImpl = process.argv.includes("--reference") ? referenceMaxArea : maxArea;

test("example", () => equal(49, maxAreaImpl([1, 8, 6, 2, 5, 4, 8, 3, 7])));
test("two lines", () => equal(1, maxAreaImpl([1, 1])));
test("zero heights", () => equal(0, maxAreaImpl([0, 0, 0])));

// Add your own cases here.

finish();
