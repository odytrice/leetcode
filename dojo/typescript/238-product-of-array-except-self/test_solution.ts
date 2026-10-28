import { finish, sequence, test } from "../shared.ts";
import { productExceptSelf } from "./solution.ts";
import { productExceptSelf as referenceProductExceptSelf } from "./reference_solution.ts";

const productExceptSelfImpl =
  process.argv.includes("--reference") ? referenceProductExceptSelf : productExceptSelf;

test("example", () => sequence([24, 12, 8, 6], productExceptSelfImpl([1, 2, 3, 4])));
test("one zero", () => sequence([0, 0, 9, 0, 0], productExceptSelfImpl([-1, 1, 0, -3, 3])));
test("two zeros", () => sequence([0, 0, 0], productExceptSelfImpl([0, 2, 0])));

// Add your own cases here.

finish();
