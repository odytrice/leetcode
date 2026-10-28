import { equal, finish, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { diameterOfBinaryTree } from "./solution.ts";
import { diameterOfBinaryTree as referenceDiameterOfBinaryTree } from "./reference_solution.ts";

const diameterOfBinaryTreeImpl =
  process.argv.includes("--reference") ? referenceDiameterOfBinaryTree : diameterOfBinaryTree;

test("example", () => equal(3, diameterOfBinaryTreeImpl(TreeNode.from([1, 2, 3, 4, 5]))));
test("single", () => equal(0, diameterOfBinaryTreeImpl(new TreeNode(1))));
test("below root", () => equal(4, diameterOfBinaryTreeImpl(TreeNode.from([1, 2, null, 3, 4, 5, null, null, 6]))));

// Add your own cases here.

finish();
