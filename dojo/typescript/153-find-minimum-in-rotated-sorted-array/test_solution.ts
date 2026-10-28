import { equal, finish, test } from "../shared.ts";
import { findMin } from "./solution.ts";
import { findMin as referenceFindMin } from "./reference_solution.ts";

const findMinImpl = process.argv.includes("--reference") ? referenceFindMin : findMin;

test("rotated", () => equal(1, findMinImpl([3, 4, 5, 1, 2])));
test("unrotated", () => equal(1, findMinImpl([1, 2, 3])));
test("single", () => equal(-5, findMinImpl([-5])));

// Add your own cases here.

finish();
