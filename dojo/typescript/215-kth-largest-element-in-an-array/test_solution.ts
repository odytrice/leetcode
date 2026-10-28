import { equal, finish, test } from "../shared.ts";
import { findKthLargest } from "./solution.ts";
import { findKthLargest as referenceFindKthLargest } from "./reference_solution.ts";

const findKthLargestImpl = process.argv.includes("--reference") ? referenceFindKthLargest : findKthLargest;

test("example", () => equal(5, findKthLargestImpl([3, 2, 1, 5, 6, 4], 2)));
test("duplicates", () => equal(4, findKthLargestImpl([3, 2, 3, 1, 2, 4, 5, 5, 6], 4)));
test("negative", () => equal(-3, findKthLargestImpl([-1, -3, -2], 3)));

// Add your own cases here.

finish();
