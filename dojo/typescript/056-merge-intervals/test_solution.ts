import { finish, sequence, test } from "../shared.ts";
import { merge } from "./solution.ts";
import { merge as referenceMerge } from "./reference_solution.ts";

const mergeImpl = process.argv.includes("--reference") ? referenceMerge : merge;

test("example", () =>
  sequence([[1, 6], [8, 10], [15, 18]], mergeImpl([[1, 3], [2, 6], [8, 10], [15, 18]])));
test("touching endpoints", () => sequence([[1, 5]], mergeImpl([[1, 4], [4, 5]])));
test("unordered and contained", () => sequence([[1, 4], [8, 10]], mergeImpl([[8, 10], [1, 4], [2, 3]])));
test("contained interval must not shrink end", () =>
  sequence([[1, 12]], mergeImpl([[1, 10], [2, 3], [9, 12]])));
test("zero length intervals", () => sequence([[1, 1], [3, 4]], mergeImpl([[3, 3], [1, 1], [3, 4]])));

// Add your own cases here.

finish();
