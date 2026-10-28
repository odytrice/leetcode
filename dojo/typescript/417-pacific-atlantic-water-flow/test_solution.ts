import { finish, rows, test } from "../shared.ts";
import { pacificAtlantic } from "./solution.ts";
import { pacificAtlantic as referencePacificAtlantic } from "./reference_solution.ts";

const pacificAtlanticImpl = process.argv.includes("--reference") ? referencePacificAtlantic : pacificAtlantic;

test("small slope", () => rows([[0, 1], [1, 0], [1, 1]], pacificAtlanticImpl([[1, 2], [4, 3]])));
test("single cell", () => rows([[0, 0]], pacificAtlanticImpl([[7]])));
test("plateau", () => rows([[0, 0], [0, 1], [1, 0], [1, 1]], pacificAtlanticImpl([[1, 1], [1, 1]])));

// Add your own cases here.

finish();
