import { check, finish, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { lowestCommonAncestor } from "./solution.ts";
import { lowestCommonAncestor as referenceLowestCommonAncestor } from "./reference_solution.ts";

const lowestCommonAncestorImpl =
  process.argv.includes("--reference") ? referenceLowestCommonAncestor : lowestCommonAncestor;

test("different subtrees", () => {
  const root = TreeNode.from([3, 5, 1]) as TreeNode;
  check(lowestCommonAncestorImpl(root, root.left as TreeNode, root.right as TreeNode) === root);
});

test("ancestor is target", () => {
  const root = TreeNode.from([3, 5, 1, 6, 2]) as TreeNode;
  const child = root.left as TreeNode;
  check(lowestCommonAncestorImpl(root, child, child.right as TreeNode) === child);
});

test("two nodes", () => {
  const root = TreeNode.from([1, 2]) as TreeNode;
  check(lowestCommonAncestorImpl(root, root, root.left as TreeNode) === root);
});

// Add your own cases here.

finish();
