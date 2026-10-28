import { equal, finish, test } from "../shared.ts";
import { rob } from "./solution.ts";
import { rob as referenceRob } from "./reference_solution.ts";

const robImpl = process.argv.includes("--reference") ? referenceRob : rob;

test("example", () => equal(12, robImpl([2, 7, 9, 3, 1])));
test("skip large neighbor", () => equal(4, robImpl([2, 1, 1, 2])));
test("single", () => equal(5, robImpl([5])));
test("zeros", () => equal(0, robImpl([0, 0])));

// Add your own cases here.

finish();
