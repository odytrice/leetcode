using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 9, 7, 8 }, s.PartitionLabels("ababcbacadefegdehijhklij")));
Test("one part", () => Sequence(new[] { 10 }, s.PartitionLabels("eccbbbbdec")));
Test("distinct", () => Sequence(new[] { 1, 1, 1 }, s.PartitionLabels("abc")));
return Finish();
