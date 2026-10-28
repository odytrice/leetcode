import { finish, sequence, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { levelOrder } from "./solution.ts";
import { levelOrder as referenceLevelOrder } from "./reference_solution.ts";

const levelOrderImpl = process.argv.includes("--reference") ? referenceLevelOrder : levelOrder;

test("example", () => {
  const result = levelOrderImpl(TreeNode.from([3, 9, 20, null, null, 15, 7]));
  sequence(["3", "9,20", "15,7"], result.map((row) => row.join(",")));
});

test("empty", () => sequence([], levelOrderImpl(null)));
test("single", () => sequence(["1"], levelOrderImpl(new TreeNode(1)).map((row) => row.join(","))));

// Add your own cases here.

finish();
