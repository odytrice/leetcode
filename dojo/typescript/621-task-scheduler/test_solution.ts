import { equal, finish, test } from "../shared.ts";
import { leastInterval } from "./solution.ts";
import { leastInterval as referenceLeastInterval } from "./reference_solution.ts";

const leastIntervalImpl = process.argv.includes("--reference") ? referenceLeastInterval : leastInterval;

test("example", () => equal(8, leastIntervalImpl([..."AAABBB"], 2)));
test("no cooldown", () => equal(6, leastIntervalImpl([..."AAABBB"], 0)));
test("single type", () => equal(7, leastIntervalImpl([..."AAA"], 2)));
test("enough filler", () => equal(6, leastIntervalImpl([..."ABCABC"], 1)));

// Add your own cases here.

finish();
