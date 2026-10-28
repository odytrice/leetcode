import { check, finish, test } from "../shared.ts";
import { ListNode } from "../shared.ts";
import { middleNode } from "./solution.ts";
import { middleNode as referenceMiddleNode } from "./reference_solution.ts";

const middleNodeImpl = process.argv.includes("--reference") ? referenceMiddleNode : middleNode;

test("odd", () => {
  const head = ListNode.from([1, 2, 3, 4, 5]) as ListNode;
  check(middleNodeImpl(head) === head.next?.next);
});

test("even", () => {
  const head = ListNode.from([1, 2, 3, 4]) as ListNode;
  check(middleNodeImpl(head) === head.next?.next);
});

test("single", () => {
  const head = new ListNode(1);
  check(middleNodeImpl(head) === head);
});

// Add your own cases here.

finish();
