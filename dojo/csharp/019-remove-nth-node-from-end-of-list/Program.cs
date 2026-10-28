using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 1, 2, 3, 5 }, ListNode.Values(s.RemoveNthFromEnd(ListNode.From(1, 2, 3, 4, 5)!, 2))));
Test("remove head", () => { var h = ListNode.From(1, 2)!; Check(ReferenceEquals(h.next, s.RemoveNthFromEnd(h, 2))); });
Test("remove only node", () => Check(s.RemoveNthFromEnd(new ListNode(1), 1) == null));
return Finish();
