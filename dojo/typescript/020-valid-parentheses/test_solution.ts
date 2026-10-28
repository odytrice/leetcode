import { equal, finish, test } from "../shared.ts";
import { isValid } from "./solution.ts";
import { isValid as referenceIsValid } from "./reference_solution.ts";

const isValidImpl = process.argv.includes("--reference") ? referenceIsValid : isValid;

test("nested", () => equal(true, isValidImpl("([]){}")));
test("crossed", () => equal(false, isValidImpl("([)]")));
test("unclosed", () => equal(false, isValidImpl("(")));
test("unopened", () => equal(false, isValidImpl(")")));

// Add your own cases here.

finish();
