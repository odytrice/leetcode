import { finish, sequence, test } from "../shared.ts";
import { insert } from "./solution.ts";
import { insert as referenceInsert } from "./reference_solution.ts";

const insertImpl = process.argv.includes("--reference") ? referenceInsert : insert;

test("example", () => sequence([[1, 5], [6, 9]], insertImpl([[1, 3], [6, 9]], [2, 5])));
test("bridge", () =>
  sequence([[1, 2], [3, 10], [12, 16]], insertImpl([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8])));
test("empty", () => sequence([[5, 7]], insertImpl([], [5, 7])));

// Add your own cases here.

finish();
