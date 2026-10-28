import { equal, finish, test } from "../shared.ts";
import { canJump } from "./solution.ts";
import { canJump as referenceCanJump } from "./reference_solution.ts";

const canJumpImpl = process.argv.includes("--reference") ? referenceCanJump : canJump;

test("reachable", () => equal(true, canJumpImpl([2, 3, 1, 1, 4])));
test("blocked", () => equal(false, canJumpImpl([3, 2, 1, 0, 4])));
test("already there", () => equal(true, canJumpImpl([0])));
test("jump over zero", () => equal(true, canJumpImpl([2, 0, 0])));

// Add your own cases here.

finish();
