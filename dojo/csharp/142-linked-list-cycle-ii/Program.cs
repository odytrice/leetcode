using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("cycle entry", () => { var h = ListNode.From(3, 2, 0, -4)!; var entry = h.next!; h.next!.next!.next!.next = entry; Check(ReferenceEquals(entry, s.DetectCycle(h))); Check(ReferenceEquals(h.next, entry)); });
Test("no cycle", () => Check(s.DetectCycle(ListNode.From(1, 2)) == null));
Test("self cycle", () => { var h = new ListNode(1); h.next = h; Check(ReferenceEquals(h, s.DetectCycle(h))); });
Test("empty", () => Check(s.DetectCycle(null) == null));
return Finish();
