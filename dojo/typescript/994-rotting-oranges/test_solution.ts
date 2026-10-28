import { equal, finish, test } from "../shared.ts";
import { orangesRotting } from "./solution.ts";
import { orangesRotting as referenceOrangesRotting } from "./reference_solution.ts";

const orangesRottingImpl = process.argv.includes("--reference") ? referenceOrangesRotting : orangesRotting;

test("example", () => equal(4, orangesRottingImpl([[2, 1, 1], [1, 1, 0], [0, 1, 1]])));
test("unreachable", () => equal(-1, orangesRottingImpl([[2, 1, 1], [0, 1, 1], [1, 0, 1]])));
test("no fresh", () => equal(0, orangesRottingImpl([[0, 2]])));
test("multiple sources", () => equal(1, orangesRottingImpl([[2, 1, 2]])));

// Add your own cases here.

finish();
