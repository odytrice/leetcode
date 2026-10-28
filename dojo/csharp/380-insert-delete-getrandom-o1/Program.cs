using static TestSupport;
RandomizedSet Make() => args.Contains("--reference") ? new ReferenceSolution() : new RandomizedSet();
Test("insert and remove", () => { var s = Make(); Equal(true, s.Insert(1)); Equal(false, s.Insert(1)); Equal(false, s.Remove(2)); Equal(true, s.Remove(1)); Equal(false, s.Remove(1)); });
Test("swap removal", () => { var s = Make(); s.Insert(10); s.Insert(20); s.Insert(30); s.Remove(20); Equal(true, s.Remove(30)); Equal(10, s.GetRandom()); });
Test("random membership", () => { var s = Make(); s.Insert(-1); s.Insert(2); s.Insert(3); s.Remove(2); for (int i = 0; i < 200; i++) Check(s.GetRandom() is -1 or 3); });
Test("reinsert", () => { var s = Make(); s.Insert(7); s.Remove(7); Equal(true, s.Insert(7)); Equal(7, s.GetRandom()); });
return Finish();
