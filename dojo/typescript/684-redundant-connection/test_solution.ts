import { finish, sequence, test } from "../shared.ts";
import { findRedundantConnection } from "./solution.ts";
import { findRedundantConnection as referenceFindRedundantConnection } from "./reference_solution.ts";

const findRedundantConnectionImpl =
  process.argv.includes("--reference") ? referenceFindRedundantConnection : findRedundantConnection;

test("triangle", () => sequence([2, 3], findRedundantConnectionImpl([[1, 2], [1, 3], [2, 3]])));
test("cycle before final edge", () =>
  sequence([1, 4], findRedundantConnectionImpl([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]])));
test("input order tie break", () =>
  sequence([1, 2], findRedundantConnectionImpl([[2, 3], [1, 3], [1, 2]])));

// Add your own cases here.

finish();
