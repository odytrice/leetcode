import { equal, finish, test } from "../shared.ts";
import { findMinArrowShots } from "./solution.ts";
import { findMinArrowShots as referenceFindMinArrowShots } from "./reference_solution.ts";

const findMinArrowShotsImpl =
  process.argv.includes("--reference") ? referenceFindMinArrowShots : findMinArrowShots;

test("example", () => equal(2, findMinArrowShotsImpl([[10, 16], [2, 8], [1, 6], [7, 12]])));
test("touching", () => equal(1, findMinArrowShotsImpl([[1, 2], [2, 3]])));
test("integer extremes", () => equal(2, findMinArrowShotsImpl([[-2147483648, -1], [0, 2147483647]])));

// Add your own cases here.

finish();
