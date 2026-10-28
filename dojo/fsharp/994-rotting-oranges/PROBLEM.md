# Drill 994: Rotting Oranges

LeetCode Medium: https://leetcode.com/problems/rotting-oranges/

In a grid, 0 is empty, 1 is fresh, and 2 is rotten. Each minute all rotten oranges simultaneously rot fresh horizontal or vertical neighbors. Return minutes until no fresh orange remains, or -1 if impossible. You may modify the grid.

Constraints: 1 to 10 rows and columns.

Example: `[[2,1,1],[1,1,0],[0,1,1]]` returns `4`. Implement `OrangesRotting(int[][] grid)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/994-rotting-oranges/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
