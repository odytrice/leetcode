import { equal, finish, test } from "../shared.ts";
import { longestConsecutive } from "./solution.ts";
import { longestConsecutive as referenceLongestConsecutive } from "./reference_solution.ts";

const longestConsecutiveImpl =
  process.argv.includes("--reference") ? referenceLongestConsecutive : longestConsecutive;

test("example", () => equal(4, longestConsecutiveImpl([100, 4, 200, 1, 3, 2])));
test("duplicates and negatives", () => equal(4, longestConsecutiveImpl([0, -1, 1, 2, 2])));
test("empty", () => equal(0, longestConsecutiveImpl([])));

// Add your own cases here.

finish();
