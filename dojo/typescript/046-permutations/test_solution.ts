import { finish, rows, test } from "../shared.ts";
import { permute } from "./solution.ts";
import { permute as referencePermute } from "./reference_solution.ts";

const permuteImpl = process.argv.includes("--reference") ? referencePermute : permute;

test("two", () => rows([[1, 2], [2, 1]], permuteImpl([1, 2])));
test("single", () => rows([[0]], permuteImpl([0])));
test("three", () =>
  rows([[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]], permuteImpl([1, 2, 3])));

// Add your own cases here.

finish();
