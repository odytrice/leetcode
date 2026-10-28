import { equal, finish, set, test } from "../shared.ts";
import { letterCombinations } from "./solution.ts";
import { letterCombinations as referenceLetterCombinations } from "./reference_solution.ts";

const letterCombinationsImpl =
  process.argv.includes("--reference") ? referenceLetterCombinations : letterCombinations;

test("example", () =>
  set(["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"], letterCombinationsImpl("23")));
test("empty", () => equal(0, letterCombinationsImpl("").length));
test("four letter digit", () => set(["p", "q", "r", "s"], letterCombinationsImpl("7")));

// Add your own cases here.

finish();
