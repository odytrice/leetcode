import { check, equal, finish, test } from "../shared.ts";
import { cloneGraph } from "./solution.ts";
import { GraphNode } from "./solution.ts";
import { cloneGraph as referenceCloneGraph } from "./reference_solution.ts";

const cloneGraphImpl = process.argv.includes("--reference") ? referenceCloneGraph : cloneGraph;

test("cycle and shared neighbors", () => {
  const originals = [1, 2, 3].map((value) => new GraphNode(value));
  for (const node of originals) node.neighbors = originals.filter((other) => other !== node);

  const copy = cloneGraphImpl(originals[0]) as GraphNode;
  const seen = new Map<number, GraphNode>();
  const queue = [copy];
  while (queue.length > 0) {
    const node = queue.pop() as GraphNode;
    const prior = seen.get(node.val);
    if (prior) {
      check(prior === node);
      continue;
    }
    check(!originals.includes(node));
    seen.set(node.val, node);
    const original = originals[node.val - 1];
    equal(
      original.neighbors.map((neighbor) => neighbor.val).sort().join(","),
      node.neighbors.map((neighbor) => neighbor.val).sort().join(","),
    );
    queue.push(...node.neighbors);
  }
  equal(3, seen.size);
});

test("isolated", () => {
  const node = new GraphNode(1);
  const copy = cloneGraphImpl(node) as GraphNode;
  check(copy !== node);
  equal(1, copy.val);
  equal(0, copy.neighbors.length);
});

test("empty", () => check(cloneGraphImpl(null) === null));

// Add your own cases here.

finish();
