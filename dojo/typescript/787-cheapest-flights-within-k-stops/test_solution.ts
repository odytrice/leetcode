import { equal, finish, test } from "../shared.ts";
import { findCheapestPrice } from "./solution.ts";
import { findCheapestPrice as referenceFindCheapestPrice } from "./reference_solution.ts";

const findCheapestPriceImpl =
  process.argv.includes("--reference") ? referenceFindCheapestPrice : findCheapestPrice;

test("one stop", () =>
  equal(200, findCheapestPriceImpl(3, [[0, 1, 100], [1, 2, 100], [0, 2, 500]], 0, 2, 1)));
test("no stops", () =>
  equal(500, findCheapestPriceImpl(3, [[0, 1, 100], [1, 2, 100], [0, 2, 500]], 0, 2, 0)));
test("unreachable", () => equal(-1, findCheapestPriceImpl(3, [[0, 1, 100]], 0, 2, 2)));
test("cheaper route exceeds stop limit", () =>
  equal(6, findCheapestPriceImpl(4, [[0, 1, 1], [1, 2, 1], [2, 3, 1], [0, 2, 5]], 0, 3, 1)));

// Add your own cases here.

finish();
