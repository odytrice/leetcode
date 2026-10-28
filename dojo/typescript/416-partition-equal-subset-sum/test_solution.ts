import { equal, finish, test } from "../shared.ts";
import { canPartition } from "./solution.ts";
import { canPartition as referenceCanPartition } from "./reference_solution.ts";

const canPartitionImpl = process.argv.includes("--reference") ? referenceCanPartition : canPartition;

test("example", () => equal(true, canPartitionImpl([1, 5, 11, 5])));
test("odd sum", () => equal(false, canPartitionImpl([1, 2, 3, 5])));
test("no element reuse", () => equal(false, canPartitionImpl([1, 2, 5])));
test("equal pair", () => equal(true, canPartitionImpl([100, 100])));

// Add your own cases here.

finish();
