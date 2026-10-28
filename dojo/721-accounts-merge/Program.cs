using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
IList<IList<string>> Accounts(params string[][] rows) => rows.Select(r => (IList<string>)r).ToList();
Test("transitive merge", () => Rows(new string[][] { ["John", "a@x", "b@x", "c@x"] }, s.AccountsMerge(Accounts(["John", "a@x"], ["John", "b@x", "c@x"], ["John", "a@x", "b@x"]))));
Test("same name distinct people", () => Rows(new string[][] { ["John", "a@x"], ["John", "b@x"] }, s.AccountsMerge(Accounts(["John", "a@x"], ["John", "b@x"]))));
Test("sorted and deduplicated", () => Rows(new string[][] { ["Mary", "a@x", "z@x"] }, s.AccountsMerge(Accounts(["Mary", "z@x", "a@x", "z@x"]))));
return Finish();
