using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("odd", () => { var h = ListNode.From(1, 2, 3, 4, 5)!; Check(ReferenceEquals(h.next!.next, s.MiddleNode(h))); });
Test("even", () => { var h = ListNode.From(1, 2, 3, 4)!; Check(ReferenceEquals(h.next!.next, s.MiddleNode(h))); });
Test("single", () => { var h = new ListNode(1); Check(ReferenceEquals(h, s.MiddleNode(h))); });
return Finish();
