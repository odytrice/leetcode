import { equal, finish, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { kthSmallest } from "./solution.ts";
import { kthSmallest as referenceKthSmallest } from "./reference_solution.ts";

const kthSmallestImpl = process.argv.includes("--reference") ? referenceKthSmallest : kthSmallest;

test("minimum", () => equal(1, kthSmallestImpl(TreeNode.from([3, 1, 4, null, 2]) as TreeNode, 1)));
test("interior", () => equal(3, kthSmallestImpl(TreeNode.from([5, 3, 6, 2, 4, null, null, 1]) as TreeNode, 3)));
test("maximum", () => equal(4, kthSmallestImpl(TreeNode.from([3, 1, 4, null, 2]) as TreeNode, 4)));

// Add your own cases here.

finish();
