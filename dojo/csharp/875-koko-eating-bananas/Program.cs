using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(4, s.MinEatingSpeed([3, 6, 7, 11], 8)));
Test("one hour per pile", () => Equal(30, s.MinEatingSpeed([30, 11, 23, 4, 20], 5)));
Test("large total hours", () => Equal(4, s.MinEatingSpeed([1_000_000_000, 1_000_000_000, 1_000_000_000], 1_000_000_000)));
Test("seeded cases against exhaustive speeds", () =>
{
    var random = new Random(875);
    for (int trial = 0; trial < 100; trial++)
    {
        var piles = Enumerable.Range(0, random.Next(1, 8)).Select(_ => random.Next(1, 25)).ToArray();
        int hours = random.Next(piles.Length, piles.Sum() + 1);
        int expected = Enumerable.Range(1, piles.Max()).First(speed => piles.Sum(p => (p + speed - 1) / speed) <= hours);
        Equal(expected, s.MinEatingSpeed(piles, hours));
    }
});
return Finish();
