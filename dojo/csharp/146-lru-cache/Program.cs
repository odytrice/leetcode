using static TestSupport;
LRUCache Make(int n) => args.Contains("--reference") ? new ReferenceSolution(n) : new LRUCache(n);
Test("eviction and access", () => { var s = Make(2); s.Put(1, 1); s.Put(2, 2); Equal(1, s.Get(1)); s.Put(3, 3); Equal(-1, s.Get(2)); s.Put(4, 4); Equal(-1, s.Get(1)); Equal(3, s.Get(3)); Equal(4, s.Get(4)); });
Test("update refreshes recency", () => { var s = Make(2); s.Put(1, 1); s.Put(2, 2); s.Put(1, 9); s.Put(3, 3); Equal(9, s.Get(1)); Equal(-1, s.Get(2)); });
Test("capacity one", () => { var s = Make(1); s.Put(1, 2); s.Put(2, 3); Equal(-1, s.Get(1)); Equal(3, s.Get(2)); });
return Finish();
