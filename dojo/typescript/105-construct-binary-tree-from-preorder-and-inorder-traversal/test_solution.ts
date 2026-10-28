import { equal, finish, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { buildTree } from "./solution.ts";
import { buildTree as referenceBuildTree } from "./reference_solution.ts";

const buildTreeImpl = process.argv.includes("--reference") ? referenceBuildTree : buildTree;

const shape = (node: TreeNode | null): string =>
  node === null ? "#" : `${node.val}(${shape(node.left)},${shape(node.right)})`;

test("example", () =>
  equal(
    shape(TreeNode.from([3, 9, 20, null, null, 15, 7])),
    shape(buildTreeImpl([3, 9, 20, 15, 7], [9, 3, 15, 20, 7])),
  ));
test("left chain", () => equal("3(2(1(#,#),#),#)", shape(buildTreeImpl([3, 2, 1], [1, 2, 3]))));
test("single", () => equal("-1(#,#)", shape(buildTreeImpl([-1], [-1]))));

// Add your own cases here.

finish();
