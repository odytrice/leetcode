import { check, finish, sequence, test } from "../shared.ts";
import { ListNode } from "../shared.ts";
import { reverseList } from "./solution.ts";
import { reverseList as referenceReverseList } from "./reference_solution.ts";

const reverseListImpl = process.argv.includes("--reference") ? referenceReverseList : reverseList;

test("example", () => sequence([3, 2, 1], ListNode.values(reverseListImpl(ListNode.from([1, 2, 3])))));
test("empty", () => check(reverseListImpl(null) === null));

test("single", () => {
  const node = new ListNode(7);
  check(reverseListImpl(node) === node);
});

// Add your own cases here.

finish();
