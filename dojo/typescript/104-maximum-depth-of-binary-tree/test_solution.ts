import { equal, finish, test } from "../shared.ts";
import { TreeNode } from "../shared.ts";
import { maxDepth } from "./solution.ts";
import { maxDepth as referenceMaxDepth } from "./reference_solution.ts";

const maxDepthImpl = process.argv.includes("--reference") ? referenceMaxDepth : maxDepth;

test("example", () => equal(3, maxDepthImpl(TreeNode.from([3, 9, 20, null, null, 15, 7]))));
test("empty", () => equal(0, maxDepthImpl(null)));
test("skewed", () => equal(3, maxDepthImpl(TreeNode.from([1, null, 2, null, 3]))));

// Add your own cases here.

finish();
