import { equal, finish, rows, test } from "../shared.ts";
import { threeSum } from "./solution.ts";
import { threeSum as referenceThreeSum } from "./reference_solution.ts";

const threeSumImpl = process.argv.includes("--reference") ? referenceThreeSum : threeSum;

test("example", () => rows([[-1, -1, 2], [-1, 0, 1]], threeSumImpl([-1, 0, 1, 2, -1, -4]), true));
test("duplicates", () => rows([[0, 0, 0]], threeSumImpl([0, 0, 0, 0]), true));
test("no answer", () => equal(0, threeSumImpl([1, 2, 3]).length));

// Add your own cases here.

finish();
