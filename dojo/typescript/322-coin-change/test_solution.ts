import { equal, finish, test } from "../shared.ts";
import { coinChange } from "./solution.ts";
import { coinChange as referenceCoinChange } from "./reference_solution.ts";

const coinChangeImpl = process.argv.includes("--reference") ? referenceCoinChange : coinChange;

test("example", () => equal(3, coinChangeImpl([1, 2, 5], 11)));
test("impossible", () => equal(-1, coinChangeImpl([2], 3)));
test("zero", () => equal(0, coinChangeImpl([1], 0)));
test("greedy fails", () => equal(2, coinChangeImpl([1, 3, 4], 6)));

// Add your own cases here.

finish();
