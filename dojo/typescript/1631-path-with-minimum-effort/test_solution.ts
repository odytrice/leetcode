import { equal, finish, test } from "../shared.ts";
import { minimumEffortPath } from "./solution.ts";
import { minimumEffortPath as referenceMinimumEffortPath } from "./reference_solution.ts";

const minimumEffortPathImpl =
  process.argv.includes("--reference") ? referenceMinimumEffortPath : minimumEffortPath;

test("example", () => equal(2, minimumEffortPathImpl([[1, 2, 2], [3, 8, 2], [5, 3, 5]])));
test("single", () => equal(0, minimumEffortPathImpl([[99]])));
test("max not sum", () => equal(1, minimumEffortPathImpl([[1, 2, 3, 4]])));
test("detour", () => equal(0, minimumEffortPathImpl([[1, 100, 1], [1, 100, 1], [1, 1, 1]])));

// Add your own cases here.

finish();
