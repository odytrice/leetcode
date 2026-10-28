import { equal, finish, test } from "../shared.ts";
import { replaceWords } from "./solution.ts";
import { replaceWords as referenceReplaceWords } from "./reference_solution.ts";

const replaceWordsImpl = process.argv.includes("--reference") ? referenceReplaceWords : replaceWords;

test("example", () =>
  equal("the cat was rat by the bat", replaceWordsImpl(["cat", "bat", "rat"], "the cattle was rattled by the battery")));
test("shortest root", () => equal("a a b", replaceWordsImpl(["aaa", "a", "aa"], "aaaa aa b")));
test("exact and absent", () => equal("cat dog", replaceWordsImpl(["cat"], "cat dog")));

// Add your own cases here.

finish();
