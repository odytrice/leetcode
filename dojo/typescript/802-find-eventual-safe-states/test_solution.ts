import { finish, sequence, test } from "../shared.ts";
import { eventualSafeNodes } from "./solution.ts";
import { eventualSafeNodes as referenceEventualSafeNodes } from "./reference_solution.ts";

const eventualSafeNodesImpl = process.argv.includes("--reference") ? referenceEventualSafeNodes : eventualSafeNodes;

test("example", () =>
  sequence([2, 4, 5, 6], eventualSafeNodesImpl([[1, 2], [2, 3], [5], [0], [5], [], []])));
test("self loop", () => sequence([1], eventualSafeNodesImpl([[0], []])));
test("all terminal", () => sequence([0, 1], eventualSafeNodesImpl([[], []])));

// Add your own cases here.

finish();
