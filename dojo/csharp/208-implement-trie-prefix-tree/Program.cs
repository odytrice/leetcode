using static TestSupport;
Trie Make() => args.Contains("--reference") ? new ReferenceSolution() : new Trie();
Test("word versus prefix", () => { var s = Make(); s.Insert("apple"); Equal(true, s.Search("apple")); Equal(false, s.Search("app")); Equal(true, s.StartsWith("app")); s.Insert("app"); Equal(true, s.Search("app")); });
Test("missing branch", () => { var s = Make(); s.Insert("cat"); Equal(false, s.Search("car")); Equal(false, s.StartsWith("z")); });
Test("duplicate insert", () => { var s = Make(); s.Insert("a"); s.Insert("a"); Equal(true, s.Search("a")); Equal(false, s.Search("aa")); });
return Finish();
