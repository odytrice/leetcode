import { equal, finish, test } from "../shared.ts";
import { findMaxLength } from "./solution.ts";
import { findMaxLength as referenceFindMaxLength } from "./reference_solution.ts";

const findMaxLengthImpl = process.argv.includes("--reference") ? referenceFindMaxLength : findMaxLength;

test("example", () => equal(2, findMaxLengthImpl([0, 1, 0])));
test("all one value", () => equal(0, findMaxLengthImpl([1, 1, 1])));
test("earliest prefix", () => equal(6, findMaxLengthImpl([0, 0, 1, 0, 1, 1, 0])));

// Add your own cases here.

finish();
