import { equal, finish, test } from "../shared.ts";
import { characterReplacement } from "./solution.ts";
import { characterReplacement as referenceCharacterReplacement } from "./reference_solution.ts";

const characterReplacementImpl =
  process.argv.includes("--reference") ? referenceCharacterReplacement : characterReplacement;

test("example", () => equal(4, characterReplacementImpl("AABABBA", 1)));
test("whole string", () => equal(4, characterReplacementImpl("ABAB", 2)));
test("no replacements", () => equal(2, characterReplacementImpl("ABBA", 0)));

// Add your own cases here.

finish();
