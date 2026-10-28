# Drill 1631: Path With Minimum Effort

LeetCode Medium: https://leetcode.com/problems/path-with-minimum-effort/

Move horizontally or vertically from top-left to bottom-right. A path's effort is the largest absolute height difference between consecutive cells, not the sum. Return the minimum possible effort.

Constraints: 1 to 100 rows and columns; heights 1 to 1,000,000.

Example: `[[1,2,2],[3,8,2],[5,3,5]]` returns `2`. Implement `MinimumEffortPath(int[][] heights)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/1631-path-with-minimum-effort/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
