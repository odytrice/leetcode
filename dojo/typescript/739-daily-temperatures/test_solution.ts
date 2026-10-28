import { finish, sequence, test } from "../shared.ts";
import { dailyTemperatures } from "./solution.ts";
import { dailyTemperatures as referenceDailyTemperatures } from "./reference_solution.ts";

const dailyTemperaturesImpl =
  process.argv.includes("--reference") ? referenceDailyTemperatures : dailyTemperatures;

test("example", () =>
  sequence([1, 1, 4, 2, 1, 1, 0, 0], dailyTemperaturesImpl([73, 74, 75, 71, 69, 72, 76, 73])));
test("increasing", () => sequence([1, 1, 1, 0], dailyTemperaturesImpl([30, 40, 50, 60])));
test("equal temperatures", () => sequence([0, 0, 0], dailyTemperaturesImpl([70, 70, 70])));
test("decreasing", () => sequence([0, 0, 0, 0], dailyTemperaturesImpl([90, 80, 70, 60])));
test("visual walkthrough", () => sequence([3, 1, 1, 0], dailyTemperaturesImpl([73, 71, 72, 74])));

// Add your own cases here.

finish();
