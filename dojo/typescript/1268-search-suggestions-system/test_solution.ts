import { finish, sequence, test } from "../shared.ts";
import { suggestedProducts } from "./solution.ts";
import { suggestedProducts as referenceSuggestedProducts } from "./reference_solution.ts";

const suggestedProductsImpl =
  process.argv.includes("--reference") ? referenceSuggestedProducts : suggestedProducts;
const lines = (rows: string[][]): string[] => rows.map((row) => row.join(","));

test("lexicographic top three", () =>
  sequence(
    lines([["baggage", "bags", "banner"], ["baggage", "bags", "banner"]]),
    lines(suggestedProductsImpl(["bags", "baggage", "banner", "box", "cloth"], "ba")),
  ));
test("missing suffix", () => sequence(lines([["a"], [], []]), lines(suggestedProductsImpl(["a"], "abc"))));
test("fewer than three", () =>
  sequence(lines([["car", "cat"], ["car", "cat"], ["cat"]]), lines(suggestedProductsImpl(["cat", "car"], "cat"))));

// Add your own cases here.

finish();
