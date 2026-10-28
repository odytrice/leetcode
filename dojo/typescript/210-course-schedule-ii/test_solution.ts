import { equal, finish, set, test } from "../shared.ts";
import { findOrder } from "./solution.ts";
import { findOrder as referenceFindOrder } from "./reference_solution.ts";

const findOrderImpl = process.argv.includes("--reference") ? referenceFindOrder : findOrder;

function verify(courses: number, edges: number[][]): void {
  const order = findOrderImpl(courses, edges);
  set(Array.from({ length: courses }, (_, index) => index), order);
  const positions = new Map(order.map((course, index) => [course, index]));
  for (const [course, prerequisite] of edges) {
    if ((positions.get(prerequisite) as number) >= (positions.get(course) as number)) {
      throw new Error("Prerequisite order violated");
    }
  }
}

test("diamond", () => verify(4, [[1, 0], [2, 0], [3, 1], [3, 2]]));
test("cycle", () => equal(0, findOrderImpl(2, [[1, 0], [0, 1]]).length));
test("isolated courses", () => verify(3, []));

// Add your own cases here.

finish();
