import { equal, finish, test } from "../shared.ts";
import { wordBreak } from "./solution.ts";
import { wordBreak as referenceWordBreak } from "./reference_solution.ts";

const wordBreakImpl = process.argv.includes("--reference") ? referenceWordBreak : wordBreak;

test("example", () => equal(true, wordBreakImpl("leetcode", ["leet", "code"])));
test("reuse", () => equal(true, wordBreakImpl("applepenapple", ["apple", "pen"])));
test("impossible suffix", () => equal(false, wordBreakImpl("catsandog", ["cats", "dog", "sand", "and", "cat"])));
test("non greedy split", () => equal(true, wordBreakImpl("aaaaaaa", ["aaaa", "aaa"])));

// Add your own cases here.

finish();
