import { finish, sequence, test } from "../shared.ts";
import { ListNode } from "../shared.ts";
import { addTwoNumbers } from "./solution.ts";
import { addTwoNumbers as referenceAddTwoNumbers } from "./reference_solution.ts";

const addTwoNumbersImpl = process.argv.includes("--reference") ? referenceAddTwoNumbers : addTwoNumbers;

test("example", () =>
  sequence(
    [7, 0, 8],
    ListNode.values(addTwoNumbersImpl(ListNode.from([2, 4, 3]) as ListNode, ListNode.from([5, 6, 4]) as ListNode)),
  ));

test("carry chain", () =>
  sequence([0, 0, 0, 1], ListNode.values(addTwoNumbersImpl(ListNode.from([9, 9, 9]) as ListNode, new ListNode(1)))));

test("zero", () => sequence([0], ListNode.values(addTwoNumbersImpl(new ListNode(0), new ListNode(0)))));

// Add your own cases here.

finish();
