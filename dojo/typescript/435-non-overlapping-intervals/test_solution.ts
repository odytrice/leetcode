import { equal, finish, test } from "../shared.ts";
import { eraseOverlapIntervals } from "./solution.ts";
import { eraseOverlapIntervals as referenceEraseOverlapIntervals } from "./reference_solution.ts";

const eraseOverlapIntervalsImpl =
  process.argv.includes("--reference") ? referenceEraseOverlapIntervals : eraseOverlapIntervals;

test("example", () => equal(1, eraseOverlapIntervalsImpl([[1, 2], [2, 3], [3, 4], [1, 3]])));
test("duplicates", () => equal(2, eraseOverlapIntervalsImpl([[1, 2], [1, 2], [1, 2]])));
test("touching", () => equal(0, eraseOverlapIntervalsImpl([[1, 2], [2, 3]])));

// Add your own cases here.

finish();
