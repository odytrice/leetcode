import { finish, sequence, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { rightSideView } from "./solution.ts";
import { rightSideView as referenceRightSideView } from "./reference_solution.ts";

const rightSideViewImpl = process.argv.includes("--reference") ? referenceRightSideView : rightSideView;

test("example", () => sequence([1, 3, 4], rightSideViewImpl(TreeNode.from([1, 2, 3, null, 5, null, 4]))));
test("left continues", () => sequence([1, 3, 4], rightSideViewImpl(TreeNode.from([1, 2, 3, 4]))));
test("empty", () => sequence([], rightSideViewImpl(null)));

// Add your own cases here.

finish();
