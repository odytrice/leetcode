import { equal, finish, test } from "../shared.ts";
import { checkInclusion } from "./solution.ts";
import { checkInclusion as referenceCheckInclusion } from "./reference_solution.ts";

const checkInclusionImpl = process.argv.includes("--reference") ? referenceCheckInclusion : checkInclusion;

test("present", () => equal(true, checkInclusionImpl("ab", "eidbaooo")));
test("absent", () => equal(false, checkInclusionImpl("ab", "eidboaoo")));
test("multiplicities", () => equal(false, checkInclusionImpl("aab", "abb")));
test("pattern longer", () => equal(false, checkInclusionImpl("abc", "ab")));

// Add your own cases here.

finish();
