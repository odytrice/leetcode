import { equal, finish, test } from "../shared.ts";
import { lengthOfLongestSubstring } from "./solution.ts";
import { lengthOfLongestSubstring as referenceLengthOfLongestSubstring } from "./reference_solution.ts";

const lengthOfLongestSubstringImpl =
  process.argv.includes("--reference") ? referenceLengthOfLongestSubstring : lengthOfLongestSubstring;

test("example", () => equal(3, lengthOfLongestSubstringImpl("abcabcbb")));
test("repeated character", () => equal(1, lengthOfLongestSubstringImpl("bbbbb")));
test("window end", () => equal(3, lengthOfLongestSubstringImpl("pwwkew")));
test("empty", () => equal(0, lengthOfLongestSubstringImpl("")));
test("previous occurrence outside window", () => equal(2, lengthOfLongestSubstringImpl("abba")));

// Add your own cases here.

finish();
