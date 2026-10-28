import { equal, finish, test } from "../shared.ts";
import { shipWithinDays } from "./solution.ts";
import { shipWithinDays as referenceShipWithinDays } from "./reference_solution.ts";

const shipWithinDaysImpl = process.argv.includes("--reference") ? referenceShipWithinDays : shipWithinDays;

test("example", () => equal(15, shipWithinDaysImpl([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 5)));
test("one day", () => equal(6, shipWithinDaysImpl([1, 2, 3], 1)));
test("one per day", () => equal(3, shipWithinDaysImpl([1, 2, 3], 3)));

// Add your own cases here.

finish();
