# Drill 435: Non-overlapping Intervals

LeetCode Medium: https://leetcode.com/problems/non-overlapping-intervals/

Return the minimum number of intervals to remove so the rest do not overlap. Intervals touching at an endpoint are nonoverlapping. You may sort the input.

Constraints: 1 to 100,000 intervals, -50,000 <= start < end <= 50,000.

Example: `[[1,2],[2,3],[3,4],[1,3]]` returns `1`. Implement `EraseOverlapIntervals(int[][] intervals)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/435-non-overlapping-intervals/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
