import { check, equal, finish, test } from "../shared.ts";
import { RandomizedSet } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (): RandomizedSet => (useReference ? new ReferenceSolution() : new RandomizedSet());

test("insert and remove", () => {
  const values = make();
  equal(true, values.insert(1));
  equal(false, values.insert(1));
  equal(false, values.remove(2));
  equal(true, values.remove(1));
  equal(false, values.remove(1));
});

test("swap removal", () => {
  const values = make();
  values.insert(10);
  values.insert(20);
  values.insert(30);
  values.remove(20);
  equal(true, values.remove(30));
  equal(10, values.getRandom());
});

test("random membership", () => {
  const values = make();
  values.insert(-1);
  values.insert(2);
  values.insert(3);
  values.remove(2);
  for (let i = 0; i < 200; i++) check([-1, 3].includes(values.getRandom()));
});

test("reinsert", () => {
  const values = make();
  values.insert(7);
  values.remove(7);
  equal(true, values.insert(7));
  equal(7, values.getRandom());
});

// Add your own cases here.

finish();
