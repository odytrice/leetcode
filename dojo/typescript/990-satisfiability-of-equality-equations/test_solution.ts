import { equal, finish, test } from "../shared.ts";
import { equationsPossible } from "./solution.ts";
import { equationsPossible as referenceEquationsPossible } from "./reference_solution.ts";

const equationsPossibleImpl =
  process.argv.includes("--reference") ? referenceEquationsPossible : equationsPossible;

test("contradiction", () => equal(false, equationsPossibleImpl(["a==b", "b!=a"])));
test("transitive and reordered", () => equal(false, equationsPossibleImpl(["a!=c", "a==b", "b==c"])));
test("consistent", () => equal(true, equationsPossibleImpl(["a==b", "b!=c"])));
test("self inequality", () => equal(false, equationsPossibleImpl(["a!=a"])));

// Add your own cases here.

finish();
