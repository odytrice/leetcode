import { check, finish, sequence, test } from "../shared.ts";
import { ListNode } from "../shared.ts";
import { removeNthFromEnd } from "./solution.ts";
import { removeNthFromEnd as referenceRemoveNthFromEnd } from "./reference_solution.ts";

const removeNthFromEndImpl =
  process.argv.includes("--reference") ? referenceRemoveNthFromEnd : removeNthFromEnd;

test("example", () =>
  sequence([1, 2, 3, 5], ListNode.values(removeNthFromEndImpl(ListNode.from([1, 2, 3, 4, 5]) as ListNode, 2))));

test("remove head", () => {
  const head = ListNode.from([1, 2]) as ListNode;
  check(removeNthFromEndImpl(head, 2) === head.next);
});

test("remove only node", () => check(removeNthFromEndImpl(new ListNode(1), 1) === null));

// Add your own cases here.

finish();
