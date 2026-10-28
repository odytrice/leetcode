import { check, equal, finish, test } from "../shared.ts";
import { copyRandomList } from "./solution.ts";
import { RandomNode } from "./solution.ts";
import { copyRandomList as referenceCopyRandomList } from "./reference_solution.ts";

const copyRandomListImpl = process.argv.includes("--reference") ? referenceCopyRandomList : copyRandomList;

test("cross pointers and duplicate values", () => {
  const first = new RandomNode(7);
  const second = new RandomNode(7);
  first.next = second;
  first.random = second;
  second.random = first;

  const copy = copyRandomListImpl(first) as RandomNode;
  check(copy !== first && copy.next !== second);
  equal(7, copy.val);
  equal(7, (copy.next as RandomNode).val);
  check(copy.random === copy.next && (copy.next as RandomNode).random === copy);
  check(first.next === second && second.random === first);
});

test("self random", () => {
  const node = new RandomNode(1);
  node.random = node;
  const copy = copyRandomListImpl(node) as RandomNode;
  check(copy !== node && copy.random === copy && copy.next === null);
});

test("empty", () => check(copyRandomListImpl(null) === null));

// Add your own cases here.

finish();
