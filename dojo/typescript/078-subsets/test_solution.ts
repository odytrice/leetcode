import { finish, rows, test } from "../shared.ts";
import { subsets } from "./solution.ts";
import { subsets as referenceSubsets } from "./reference_solution.ts";

const subsetsImpl = process.argv.includes("--reference") ? referenceSubsets : subsets;

test("two values", () => rows([[], [1], [2], [1, 2]], subsetsImpl([1, 2]), true));
test("single", () => rows([[], [0]], subsetsImpl([0]), true));
test("three values", () => rows([[], [-1], [0], [1], [-1, 0], [-1, 1], [0, 1], [-1, 0, 1]], subsetsImpl([-1, 0, 1]), true));

// Add your own cases here.

finish();
