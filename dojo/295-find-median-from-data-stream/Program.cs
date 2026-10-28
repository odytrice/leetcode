using static TestSupport;
MedianFinder Make() => args.Contains("--reference") ? new ReferenceSolution() : new MedianFinder();
Test("example", () => { var s = Make(); s.AddNum(1); s.AddNum(2); Equal(1.5, s.FindMedian()); s.AddNum(3); Equal(2.0, s.FindMedian()); });
Test("negative values", () => { var s = Make(); s.AddNum(-1); s.AddNum(-2); Equal(-1.5, s.FindMedian()); s.AddNum(-3); Equal(-2.0, s.FindMedian()); });
Test("duplicates", () => { var s = Make(); for (int i = 0; i < 8; i++) { s.AddNum(7); Equal(7.0, s.FindMedian()); } });
return Finish();
