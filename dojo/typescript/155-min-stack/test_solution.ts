import { equal, finish, test } from "../shared.ts";
import { MinStack } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (): MinStack => (useReference ? new ReferenceSolution() : new MinStack());

test("example", () => {
  const stack = make();
  stack.push(-2);
  stack.push(0);
  stack.push(-3);
  equal(-3, stack.getMin());
  stack.pop();
  equal(0, stack.top());
  equal(-2, stack.getMin());
});

test("duplicate minimum", () => {
  const stack = make();
  stack.push(1);
  stack.push(1);
  stack.pop();
  equal(1, stack.getMin());
});

test("int limits", () => {
  const stack = make();
  stack.push(-2147483648);
  stack.push(2147483647);
  equal(-2147483648, stack.getMin());
  equal(2147483647, stack.top());
});

// Add your own cases here.

finish();
