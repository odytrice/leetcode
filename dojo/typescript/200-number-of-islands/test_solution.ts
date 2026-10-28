import { equal, finish, test } from "../shared.ts";
import { numIslands } from "./solution.ts";
import { numIslands as referenceNumIslands } from "./reference_solution.ts";

const numIslandsImpl = process.argv.includes("--reference") ? referenceNumIslands : numIslands;
const solve = (rows: string[]): number => numIslandsImpl(rows.map((row) => [...row]));

test("example one", () => equal(1, solve(["11110", "11010", "11000", "00000"])));
test("example two", () => equal(3, solve(["11000", "11000", "00100", "00011"])));
test("diagonal cells are separate", () => equal(2, solve(["10", "01"])));
test("all water", () => equal(0, solve(["000", "000"])));
test("single column", () => equal(3, solve(["1", "1", "0", "1", "0", "1"])));

// Add your own cases here.

finish();
