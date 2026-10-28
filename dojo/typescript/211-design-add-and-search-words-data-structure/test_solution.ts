import { check, finish, test } from "../shared.ts";
import { WordDictionary } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (): WordDictionary => (useReference ? new ReferenceSolution() : new WordDictionary());

test("wildcards", () => {
  const dictionary = make();
  for (const word of ["bad", "dad", "mad"]) dictionary.addWord(word);
  check(dictionary.search(".ad"));
  check(dictionary.search("b.."));
  check(!dictionary.search("pad"));
});

test("exact length", () => {
  const dictionary = make();
  dictionary.addWord("abc");
  check(!dictionary.search(".."));
  check(!dictionary.search("abc."));
  check(!dictionary.search("ab"));
});

test("branch exploration", () => {
  const dictionary = make();
  dictionary.addWord("cat");
  dictionary.addWord("dog");
  check(dictionary.search(".og"));
  check(!dictionary.search(".ox"));
});

// Add your own cases here.

finish();
