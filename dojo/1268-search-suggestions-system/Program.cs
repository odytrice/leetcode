using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
void Verify(string[][] expected, string[] products, string search) => Sequence(expected.Select(x => string.Join(',', x)), s.SuggestedProducts(products, search).Select(x => string.Join(',', x)));
Test("lexicographic top three", () => Verify([["baggage", "bags", "banner"], ["baggage", "bags", "banner"]], ["bags", "baggage", "banner", "box", "cloth"], "ba"));
Test("missing suffix", () => Verify([["a"], [], []], ["a"], "abc"));
Test("fewer than three", () => Verify([["car", "cat"], ["car", "cat"], ["cat"]], ["cat", "car"], "cat"));
return Finish();
