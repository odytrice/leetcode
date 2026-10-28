import { equal, finish, test } from "../shared.ts";
import { threeSumClosest } from "./solution.ts";
import { threeSumClosest as referenceThreeSumClosest } from "./reference_solution.ts";

const threeSumClosestImpl =
  process.argv.includes("--reference") ? referenceThreeSumClosest : threeSumClosest;

test("example", () => equal(2, threeSumClosestImpl([-1, 2, 1, -4], 1)));
test("zeros", () => equal(0, threeSumClosestImpl([0, 0, 0], 1)));
test("exact", () => equal(3, threeSumClosestImpl([1, 1, 1, 0], 3)));

// Add your own cases here.

finish();
