import { equal, finish, test } from "../shared.ts";
import { MedianFinder } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (): MedianFinder => (useReference ? new ReferenceSolution() : new MedianFinder());

test("example", () => {
  const finder = make();
  finder.addNum(1);
  finder.addNum(2);
  equal(1.5, finder.findMedian());
  finder.addNum(3);
  equal(2.0, finder.findMedian());
});

test("negative values", () => {
  const finder = make();
  finder.addNum(-1);
  finder.addNum(-2);
  equal(-1.5, finder.findMedian());
  finder.addNum(-3);
  equal(-2.0, finder.findMedian());
});

test("duplicates", () => {
  const finder = make();
  for (let index = 0; index < 8; index++) {
    finder.addNum(7);
    equal(7.0, finder.findMedian());
  }
});

// Add your own cases here.

finish();
