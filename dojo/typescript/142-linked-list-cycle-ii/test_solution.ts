import { check, finish, test } from "../shared.ts";
import { ListNode } from "../shared.ts";
import { detectCycle } from "./solution.ts";
import { detectCycle as referenceDetectCycle } from "./reference_solution.ts";

const detectCycleImpl = process.argv.includes("--reference") ? referenceDetectCycle : detectCycle;

test("cycle entry", () => {
  const head = ListNode.from([3, 2, 0, -4]) as ListNode;
  const entry = head.next as ListNode;
  (head.next?.next?.next as ListNode).next = entry;
  check(detectCycleImpl(head) === entry);
  check(head.next === entry);
});

test("no cycle", () => check(detectCycleImpl(ListNode.from([1, 2])) === null));

test("self cycle", () => {
  const head = new ListNode(1);
  head.next = head;
  check(detectCycleImpl(head) === head);
});

test("empty", () => check(detectCycleImpl(null) === null));

// Add your own cases here.

finish();
