import { equal, finish, test } from "../shared.ts";
import { search } from "./solution.ts";
import { search as referenceSearch } from "./reference_solution.ts";

const searchImpl = process.argv.includes("--reference") ? referenceSearch : search;

test("rotated", () => equal(4, searchImpl([4, 5, 6, 7, 0, 1, 2], 0)));
test("absent", () => equal(-1, searchImpl([4, 5, 6, 7, 0, 1, 2], 3)));
test("unrotated", () => equal(2, searchImpl([1, 2, 3], 3)));
test("single", () => equal(0, searchImpl([1], 1)));

// Add your own cases here.

finish();
