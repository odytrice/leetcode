import { equal, finish, test } from "../shared.ts";
import { numDecodings } from "./solution.ts";
import { numDecodings as referenceNumDecodings } from "./reference_solution.ts";

const numDecodingsImpl = process.argv.includes("--reference") ? referenceNumDecodings : numDecodings;

test("example", () => equal(3, numDecodingsImpl("226")));
test("leading zero", () => equal(0, numDecodingsImpl("06")));
test("valid zeros", () => equal(1, numDecodingsImpl("1010")));
test("invalid zero", () => equal(0, numDecodingsImpl("100")));
test("pair too large", () => equal(1, numDecodingsImpl("27")));

// Add your own cases here.

finish();
