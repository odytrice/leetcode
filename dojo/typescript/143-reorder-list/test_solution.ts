import { finish, sequence, test } from "../shared.ts";
import { ListNode } from "../shared.ts";
import { reorderList } from "./solution.ts";
import { reorderList as referenceReorderList } from "./reference_solution.ts";

const reorderListImpl = process.argv.includes("--reference") ? referenceReorderList : reorderList;

function verify(values: number[], expected: number[]): void {
  const head = ListNode.from(values) as ListNode;
  reorderListImpl(head);
  sequence(expected, ListNode.values(head));
}

test("odd", () => verify([1, 2, 3, 4, 5], [1, 5, 2, 4, 3]));
test("even", () => verify([1, 2, 3, 4], [1, 4, 2, 3]));
test("single", () => verify([1], [1]));

// Add your own cases here.

finish();
