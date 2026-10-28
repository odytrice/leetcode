import { equal, finish, test } from "../shared.ts";
import { canFinish } from "./solution.ts";
import { canFinish as referenceCanFinish } from "./reference_solution.ts";

const canFinishImpl = process.argv.includes("--reference") ? referenceCanFinish : canFinish;

test("possible", () => equal(true, canFinishImpl(2, [[1, 0]])));
test("cycle", () => equal(false, canFinishImpl(2, [[1, 0], [0, 1]])));
test("disconnected cycle", () => equal(false, canFinishImpl(4, [[1, 0], [2, 3], [3, 2]])));
test("no edges", () => equal(true, canFinishImpl(3, [])));

// Add your own cases here.

finish();
