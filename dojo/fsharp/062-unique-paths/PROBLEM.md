# Drill 062: Unique Paths

LeetCode Medium: https://leetcode.com/problems/unique-paths/

Count paths from the top-left cell to the bottom-right cell of an m by n grid. Each move is exactly one cell right or down; there are no obstacles.

Constraints: 1 <= m,n <= 100; the answer is guaranteed <= 2,000,000,000.

Example: `3, 7` returns `28`. Implement `UniquePaths(int m, int n)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/062-unique-paths/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
