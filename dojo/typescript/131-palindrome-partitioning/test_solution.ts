import { finish, rows, test } from "../shared.ts";
import { partition } from "./solution.ts";
import { partition as referencePartition } from "./reference_solution.ts";

const partitionImpl = process.argv.includes("--reference") ? referencePartition : partition;

test("example", () => rows([["a", "a", "b"], ["aa", "b"]], partitionImpl("aab")));
test("single", () => rows([["a"]], partitionImpl("a")));
test("whole palindrome", () => rows([["a", "b", "a"], ["aba"]], partitionImpl("aba")));

// Add your own cases here.

finish();
