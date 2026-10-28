import { finish, sequence, set, test } from "../shared.ts";
import { findWords } from "./solution.ts";
import { findWords as referenceFindWords } from "./reference_solution.ts";

const findWordsImpl = process.argv.includes("--reference") ? referenceFindWords : findWords;

test("example and restored", () => {
  const board = [["a", "b"], ["c", "d"]];
  set(["ab", "ac"], findWordsImpl(board, ["ab", "ac", "ad"]));
  sequence(["ab", "cd"], board.map((row) => row.join("")));
});

test("multiple paths one result", () => set(["aa"], findWordsImpl([["a", "a"], ["a", "a"]], ["aa"])));
test("prefix words and no reuse", () => set(["a", "ab"], findWordsImpl([["a", "b"]], ["a", "ab", "aba"])));

// Add your own cases here.

finish();
