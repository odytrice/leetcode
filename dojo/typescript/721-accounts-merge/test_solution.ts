import { finish, set, test } from "../shared.ts";
import { accountsMerge } from "./solution.ts";
import { accountsMerge as referenceAccountsMerge } from "./reference_solution.ts";

const accountsMergeImpl = process.argv.includes("--reference") ? referenceAccountsMerge : accountsMerge;

test("transitive merge", () =>
  set(
    [["John", "a@x", "b@x", "c@x"]],
    accountsMergeImpl([["John", "a@x"], ["John", "b@x", "c@x"], ["John", "a@x", "b@x"]]),
  ));
test("same name distinct people", () =>
  set([["John", "a@x"], ["John", "b@x"]], accountsMergeImpl([["John", "a@x"], ["John", "b@x"]])));
test("sorted and deduplicated", () =>
  set([["Mary", "a@x", "z@x"]], accountsMergeImpl([["Mary", "z@x", "a@x", "z@x"]])));

// Add your own cases here.

finish();
