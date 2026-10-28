import { equal, finish, test } from "../shared.ts";
import { evalRPN } from "./solution.ts";
import { evalRPN as referenceEvalRPN } from "./reference_solution.ts";

const evalRPNImpl = process.argv.includes("--reference") ? referenceEvalRPN : evalRPN;

test("example", () => equal(9, evalRPNImpl(["2", "1", "+", "3", "*"])));
test("operand order", () => equal(-1, evalRPNImpl(["2", "3", "-"])));
test("negative division", () => equal(-2, evalRPNImpl(["-7", "3", "/"])));

// Add your own cases here.

finish();
