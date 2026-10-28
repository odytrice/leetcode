import { equal, finish, test } from "../shared.ts";
import { NumMatrix } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (matrix: number[][]): NumMatrix =>
  useReference ? new ReferenceSolution(matrix) : new NumMatrix(matrix);

test("whole rectangle", () => equal(10, make([[1, 2], [3, 4]]).sumRegion(0, 0, 1, 1)));
test("interior", () => equal(8, make([[1, 2, 3], [4, 5, 6], [7, 8, 9]]).sumRegion(2, 1, 2, 1)));

test("negatives", () => {
  const values = make([[-1, 2], [3, -4]]);
  equal(-1, values.sumRegion(1, 0, 1, 1));
  equal(0, values.sumRegion(0, 0, 1, 1));
});

// Add your own cases here.

finish();
