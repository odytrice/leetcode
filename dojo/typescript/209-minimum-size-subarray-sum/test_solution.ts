import { equal, finish, test } from "../shared.ts";
import { minSubArrayLen } from "./solution.ts";
import { minSubArrayLen as referenceMinSubArrayLen } from "./reference_solution.ts";

const minSubArrayLenImpl = process.argv.includes("--reference") ? referenceMinSubArrayLen : minSubArrayLen;

test("example", () => equal(2, minSubArrayLenImpl(7, [2, 3, 1, 2, 4, 3])));
test("one element", () => equal(1, minSubArrayLenImpl(4, [1, 4, 4])));
test("unreachable", () => equal(0, minSubArrayLenImpl(11, [1, 1, 1, 1])));

// Add your own cases here.

finish();
