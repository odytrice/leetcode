import { equal, finish, test } from "../shared.ts";
import { minCostConnectPoints } from "./solution.ts";
import { minCostConnectPoints as referenceMinCostConnectPoints } from "./reference_solution.ts";

const minCostConnectPointsImpl =
  process.argv.includes("--reference") ? referenceMinCostConnectPoints : minCostConnectPoints;

test("example", () => equal(20, minCostConnectPointsImpl([[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]])));
test("single", () => equal(0, minCostConnectPointsImpl([[4, -2]])));
test("negative coordinates", () => equal(18, minCostConnectPointsImpl([[3, 12], [-2, 5], [-4, 1]])));
test("coordinate limits", () =>
  equal(4_000_000, minCostConnectPointsImpl([[-1_000_000, -1_000_000], [1_000_000, 1_000_000]])));

// Add your own cases here.

finish();
