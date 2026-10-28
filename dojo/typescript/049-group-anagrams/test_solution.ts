import { finish, rows, test } from "../shared.ts";
import { groupAnagrams } from "./solution.ts";
import { groupAnagrams as referenceGroupAnagrams } from "./reference_solution.ts";

const groupAnagramsImpl = process.argv.includes("--reference") ? referenceGroupAnagrams : groupAnagrams;

test("example", () =>
  rows([["eat", "tea", "ate"], ["tan", "nat"], ["bat"]],
    groupAnagramsImpl(["eat", "tea", "tan", "ate", "nat", "bat"]), true));
test("empty strings", () => rows([["", ""]], groupAnagramsImpl(["", ""]), true));
test("letter counts", () => rows([["ab", "ba"], ["aab"]], groupAnagramsImpl(["ab", "aab", "ba"]), true));

// Add your own cases here.

finish();
