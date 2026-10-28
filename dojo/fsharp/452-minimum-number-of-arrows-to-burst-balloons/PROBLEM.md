# Drill 452: Minimum Number of Arrows to Burst Balloons

LeetCode Medium: https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/

Each balloon spans a closed interval on the x-axis. An arrow at x bursts every balloon whose interval contains x. Return the fewest arrows needed to burst all balloons. You may sort the input.

Constraints: 1 to 100,000 intervals; signed 32-bit endpoints with start < end.

Example: `[[10,16],[2,8],[1,6],[7,12]]` returns `2`. Implement `FindMinArrowShots(int[][] points)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/452-minimum-number-of-arrows-to-burst-balloons/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
