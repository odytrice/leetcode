import { equal, finish, test } from "../shared.ts";
import { minEatingSpeed } from "./solution.ts";
import { minEatingSpeed as referenceMinEatingSpeed } from "./reference_solution.ts";

const minEatingSpeedImpl = process.argv.includes("--reference") ? referenceMinEatingSpeed : minEatingSpeed;

test("example", () => equal(4, minEatingSpeedImpl([3, 6, 7, 11], 8)));
test("one hour per pile", () => equal(30, minEatingSpeedImpl([30, 11, 23, 4, 20], 5)));
test("large total hours", () =>
  equal(4, minEatingSpeedImpl([1_000_000_000, 1_000_000_000, 1_000_000_000], 1_000_000_000)));

// Add your own cases here.

finish();
