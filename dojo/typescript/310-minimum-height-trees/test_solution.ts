import { finish, sequence, test } from "../shared.ts";
import { findMinHeightTrees } from "./solution.ts";
import { findMinHeightTrees as referenceFindMinHeightTrees } from "./reference_solution.ts";

const findMinHeightTreesImpl =
  process.argv.includes("--reference") ? referenceFindMinHeightTrees : findMinHeightTrees;

test("star", () => sequence([1], findMinHeightTreesImpl(4, [[1, 0], [1, 2], [1, 3]])));
test("two centers", () => sequence([1, 2], findMinHeightTreesImpl(4, [[0, 1], [1, 2], [2, 3]])));
test("single", () => sequence([0], findMinHeightTreesImpl(1, [])));

// Add your own cases here.

finish();
