import { equal, finish, test } from "../shared.ts";
import { longestCommonSubsequence } from "./solution.ts";
import { longestCommonSubsequence as referenceLongestCommonSubsequence } from "./reference_solution.ts";

const longestCommonSubsequenceImpl =
  process.argv.includes("--reference") ? referenceLongestCommonSubsequence : longestCommonSubsequence;

test("example", () => equal(3, longestCommonSubsequenceImpl("abcde", "ace")));
test("disjoint", () => equal(0, longestCommonSubsequenceImpl("abc", "def")));
test("repeated letters", () => equal(2, longestCommonSubsequenceImpl("aaaa", "aa")));
test("order matters", () => equal(1, longestCommonSubsequenceImpl("abc", "cba")));

// Add your own cases here.

finish();
