import { equal, finish, test } from "../shared.ts";
import { decodeString } from "./solution.ts";
import { decodeString as referenceDecodeString } from "./reference_solution.ts";

const decodeStringImpl = process.argv.includes("--reference") ? referenceDecodeString : decodeString;

test("nested", () => equal("accaccacc", decodeStringImpl("3[a2[c]]")));
test("adjacent", () => equal("abcabccdcdcdef", decodeStringImpl("2[abc]3[cd]ef")));
test("multiple digits", () => equal("a".repeat(12), decodeStringImpl("12[a]")));

// Add your own cases here.

finish();
