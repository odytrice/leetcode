import { equal, finish, test } from "../shared.ts";
import { uniquePaths } from "./solution.ts";
import { uniquePaths as referenceUniquePaths } from "./reference_solution.ts";

const uniquePathsImpl = process.argv.includes("--reference") ? referenceUniquePaths : uniquePaths;

test("example", () => equal(28, uniquePathsImpl(3, 7)));
test("one row", () => equal(1, uniquePathsImpl(1, 100)));
test("one column", () => equal(1, uniquePathsImpl(100, 1)));
test("square", () => equal(6, uniquePathsImpl(3, 3)));

// Add your own cases here.

finish();
