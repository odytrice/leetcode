import { finish, rows, test } from "../shared.ts";
import { kClosest } from "./solution.ts";
import { kClosest as referenceKClosest } from "./reference_solution.ts";

const kClosestImpl = process.argv.includes("--reference") ? referenceKClosest : kClosest;

test("example", () => rows([[-2, 2]], kClosestImpl([[1, 3], [-2, 2]], 1)));
test("all points", () => rows([[1, 2], [3, 4]], kClosestImpl([[1, 2], [3, 4]], 2)));
test("duplicates", () => rows([[0, 0], [0, 0]], kClosestImpl([[0, 0], [0, 0], [1, 1]], 2)));

// Add your own cases here.

finish();
