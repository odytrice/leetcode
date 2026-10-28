import { finish, rows, test } from "../shared.ts";
import { subsetsWithDup } from "./solution.ts";
import { subsetsWithDup as referenceSubsetsWithDup } from "./reference_solution.ts";

const subsetsWithDupImpl = process.argv.includes("--reference") ? referenceSubsetsWithDup : subsetsWithDup;

test("example", () =>
  rows([[], [1], [2], [1, 2], [2, 2], [1, 2, 2]], subsetsWithDupImpl([1, 2, 2]), true));
test("all same", () => rows([[], [0], [0, 0]], subsetsWithDupImpl([0, 0]), true));
test("unsorted", () => rows([[], [-1], [2], [-1, 2]], subsetsWithDupImpl([2, -1]), true));

// Add your own cases here.

finish();
