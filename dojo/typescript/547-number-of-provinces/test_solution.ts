import { equal, finish, test } from "../shared.ts";
import { findCircleNum } from "./solution.ts";
import { findCircleNum as referenceFindCircleNum } from "./reference_solution.ts";

const findCircleNumImpl = process.argv.includes("--reference") ? referenceFindCircleNum : findCircleNum;

test("example", () => equal(2, findCircleNumImpl([[1, 1, 0], [1, 1, 0], [0, 0, 1]])));
test("isolated", () => equal(3, findCircleNumImpl([[1, 0, 0], [0, 1, 0], [0, 0, 1]])));
test("transitive", () => equal(1, findCircleNumImpl([[1, 1, 0], [1, 1, 1], [0, 1, 1]])));

// Add your own cases here.

finish();
