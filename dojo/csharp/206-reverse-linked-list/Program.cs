using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => { var head = ListNode.From(1, 2, 3)!; var tail = head.next!.next; var result = s.ReverseList(head); Check(ReferenceEquals(tail, result)); Sequence(new[] { 3, 2, 1 }, ListNode.Values(result)); });
Test("empty", () => Check(s.ReverseList(null) == null));
Test("single", () => { var n = new ListNode(7); Check(ReferenceEquals(n, s.ReverseList(n))); });
return Finish();
