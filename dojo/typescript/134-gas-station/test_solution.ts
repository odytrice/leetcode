import { equal, finish, test } from "../shared.ts";
import { canCompleteCircuit } from "./solution.ts";
import { canCompleteCircuit as referenceCanCompleteCircuit } from "./reference_solution.ts";

const canCompleteCircuitImpl =
  process.argv.includes("--reference") ? referenceCanCompleteCircuit : canCompleteCircuit;

test("example", () => equal(3, canCompleteCircuitImpl([1, 2, 3, 4, 5], [3, 4, 5, 1, 2])));
test("impossible", () => equal(-1, canCompleteCircuitImpl([2, 3, 4], [3, 4, 3])));
test("single", () => equal(0, canCompleteCircuitImpl([5], [5])));

// Add your own cases here.

finish();
