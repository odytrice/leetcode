import { equal, finish, test } from "../shared.ts";
import { shortestPathBinaryMatrix } from "./solution.ts";
import { shortestPathBinaryMatrix as referenceShortestPath } from "./reference_solution.ts";

const shortestPathImpl = process.argv.includes("--reference") ? referenceShortestPath : shortestPathBinaryMatrix;

test("diagonal", () => equal(2, shortestPathImpl([[0, 1], [1, 0]])));
test("single", () => equal(1, shortestPathImpl([[0]])));
test("blocked start", () => equal(-1, shortestPathImpl([[1, 0], [0, 0]])));
test("disconnected", () => equal(-1, shortestPathImpl([[0, 0, 0], [1, 1, 1], [0, 0, 0]])));

// Add your own cases here.

finish();
