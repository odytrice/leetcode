import { equal, finish, set, test } from "../shared.ts";
import { topKFrequent } from "./solution.ts";
import { topKFrequent as referenceTopKFrequent } from "./reference_solution.ts";

const topKFrequentImpl = process.argv.includes("--reference") ? referenceTopKFrequent : topKFrequent;

test("example", () => set([1, 2], topKFrequentImpl([1, 1, 1, 2, 2, 3], 2)));
test("single element", () => set([1], topKFrequentImpl([1], 1)));
test("negative values", () => set([-1, 4], topKFrequentImpl([4, 4, 4, -1, -1, 2], 2)));

// Add your own cases here.

finish();
