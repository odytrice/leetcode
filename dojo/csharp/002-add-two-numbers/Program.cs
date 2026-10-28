using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 7, 0, 8 }, ListNode.Values(s.AddTwoNumbers(ListNode.From(2, 4, 3)!, ListNode.From(5, 6, 4)!))));
Test("carry chain", () => Sequence(new[] { 0, 0, 0, 1 }, ListNode.Values(s.AddTwoNumbers(ListNode.From(9, 9, 9)!, new ListNode(1)))));
Test("zero", () => Sequence(new[] { 0 }, ListNode.Values(s.AddTwoNumbers(new ListNode(0), new ListNode(0)))));
return Finish();
