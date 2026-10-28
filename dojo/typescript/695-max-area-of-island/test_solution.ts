import { equal, finish, test } from "../shared.ts";
import { maxAreaOfIsland } from "./solution.ts";
import { maxAreaOfIsland as referenceMaxAreaOfIsland } from "./reference_solution.ts";

const maxAreaOfIslandImpl = process.argv.includes("--reference") ? referenceMaxAreaOfIsland : maxAreaOfIsland;

test("example", () => equal(3, maxAreaOfIslandImpl([[1, 1, 0], [0, 1, 0], [1, 0, 1]])));
test("water", () => equal(0, maxAreaOfIslandImpl([[0, 0]])));
test("diagonal", () => equal(1, maxAreaOfIslandImpl([[1, 0], [0, 1]])));

// Add your own cases here.

finish();
