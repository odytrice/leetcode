import { equal, finish, test } from "../shared.ts";
import { networkDelayTime } from "./solution.ts";
import { networkDelayTime as referenceNetworkDelayTime } from "./reference_solution.ts";

const networkDelayTimeImpl = process.argv.includes("--reference") ? referenceNetworkDelayTime : networkDelayTime;

test("example", () => equal(2, networkDelayTimeImpl([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2)));
test("directed unreachable", () => equal(-1, networkDelayTimeImpl([[1, 2, 1]], 2, 2)));
test("improved route", () => equal(2, networkDelayTimeImpl([[1, 2, 10], [1, 3, 1], [3, 2, 1]], 3, 1)));
test("zero weight", () => equal(0, networkDelayTimeImpl([[1, 2, 0]], 2, 1)));

// Add your own cases here.

finish();
