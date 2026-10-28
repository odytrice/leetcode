import { finish, sequence, test } from "../shared.ts";
import { sortColors } from "./solution.ts";
import { sortColors as referenceSortColors } from "./reference_solution.ts";

const sortColorsImpl = process.argv.includes("--reference") ? referenceSortColors : sortColors;

function verify(values: number[], expected: number[]): void {
  const copy = [...values];
  sortColorsImpl(copy);
  sequence(expected, copy);
}

test("example", () => verify([2, 0, 2, 1, 1, 0], [0, 0, 1, 1, 2, 2]));
test("reverse", () => verify([2, 1, 0], [0, 1, 2]));
test("single", () => verify([2], [2]));

// Add your own cases here.

finish();
