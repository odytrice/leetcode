import { equal, finish, sequence, test } from "../shared.ts";
import { exist } from "./solution.ts";
import { exist as referenceExist } from "./reference_solution.ts";

const existImpl = process.argv.includes("--reference") ? referenceExist : exist;
const makeBoard = (): string[][] => ["ABCE", "SFCS", "ADEE"].map((row) => [...row]);

test("found and restored", () => {
  const grid = makeBoard();
  equal(true, existImpl(grid, "ABCCED"));
  sequence(["ABCE", "SFCS", "ADEE"], grid.map((row) => row.join("")));
});

test("no cell reuse", () => equal(false, existImpl(makeBoard(), "ABCB")));
test("backtracking", () => equal(true, existImpl(makeBoard(), "SEE")));
test("single", () => equal(true, existImpl([["a"]], "a")));

// Add your own cases here.

finish();
