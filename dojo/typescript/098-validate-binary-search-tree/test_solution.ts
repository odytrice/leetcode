import { equal, finish, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { isValidBST } from "./solution.ts";
import { isValidBST as referenceIsValidBST } from "./reference_solution.ts";

const isValidBSTImpl = process.argv.includes("--reference") ? referenceIsValidBST : isValidBST;

test("valid", () => equal(true, isValidBSTImpl(TreeNode.from([2, 1, 3]))));
test("ancestor violation", () => equal(false, isValidBSTImpl(TreeNode.from([5, 1, 7, null, null, 4, 8]))));
test("duplicate", () => equal(false, isValidBSTImpl(TreeNode.from([2, 2, 3]))));
test("integer limits", () => equal(true, isValidBSTImpl(TreeNode.from([0, -2147483648, 2147483647]))));

// Add your own cases here.

finish();
