using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("cross pointers and duplicate values", () => { var a = new Node(7); var b = new Node(7); a.next = b; a.random = b; b.random = a; var x = s.CopyRandomList(a)!; Check(!ReferenceEquals(a, x) && !ReferenceEquals(b, x.next)); Equal(7, x.val); Equal(7, x.next!.val); Check(ReferenceEquals(x.random, x.next) && ReferenceEquals(x.next.random, x)); Check(ReferenceEquals(a.next, b) && ReferenceEquals(b.random, a)); });
Test("self random", () => { var a = new Node(1); a.random = a; var x = s.CopyRandomList(a)!; Check(!ReferenceEquals(a, x) && ReferenceEquals(x, x.random) && x.next == null); });
Test("empty", () => Check(s.CopyRandomList(null) == null));
return Finish();
