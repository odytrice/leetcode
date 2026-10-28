using static TestSupport;
WordDictionary Make() => args.Contains("--reference") ? new ReferenceSolution() : new WordDictionary();
Test("wildcards", () => { var s = Make(); s.AddWord("bad"); s.AddWord("dad"); s.AddWord("mad"); Equal(true, s.Search(".ad")); Equal(true, s.Search("b..")); Equal(false, s.Search("pad")); });
Test("exact length", () => { var s = Make(); s.AddWord("abc"); Equal(false, s.Search("..")); Equal(false, s.Search("abc.")); Equal(false, s.Search("ab")); });
Test("branch exploration", () => { var s = Make(); s.AddWord("cat"); s.AddWord("dog"); Equal(true, s.Search(".og")); Equal(false, s.Search(".ox")); });
return Finish();
