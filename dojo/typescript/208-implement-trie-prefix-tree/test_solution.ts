import { check, finish, test } from "../shared.ts";
import { Trie } from "./solution.ts";
import { ReferenceSolution } from "./reference_solution.ts";

const useReference = process.argv.includes("--reference");
const make = (): Trie => (useReference ? new ReferenceSolution() : new Trie());

test("word versus prefix", () => {
  const trie = make();
  trie.insert("apple");
  check(trie.search("apple"));
  check(!trie.search("app"));
  check(trie.startsWith("app"));
  trie.insert("app");
  check(trie.search("app"));
});

test("missing branch", () => {
  const trie = make();
  trie.insert("cat");
  check(!trie.search("car"));
  check(!trie.startsWith("z"));
});

test("duplicate insert", () => {
  const trie = make();
  trie.insert("a");
  trie.insert("a");
  check(trie.search("a"));
  check(!trie.search("aa"));
});

// Add your own cases here.

finish();
