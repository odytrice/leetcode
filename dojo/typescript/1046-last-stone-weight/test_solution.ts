import { equal, finish, test } from "../shared.ts";
import { lastStoneWeight } from "./solution.ts";
import { lastStoneWeight as referenceLastStoneWeight } from "./reference_solution.ts";

const lastStoneWeightImpl = process.argv.includes("--reference") ? referenceLastStoneWeight : lastStoneWeight;

test("example", () => equal(1, lastStoneWeightImpl([2, 7, 4, 1, 8, 1])));
test("equal pair", () => equal(0, lastStoneWeightImpl([3, 3])));
test("single", () => equal(7, lastStoneWeightImpl([7])));

// Add your own cases here.

finish();
