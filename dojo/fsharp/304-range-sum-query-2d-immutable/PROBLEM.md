# Drill 304: Range Sum Query 2D: Immutable

LeetCode Medium: https://leetcode.com/problems/range-sum-query-2d-immutable/

Return the sum of the inclusive rectangle between valid top-left and bottom-right coordinates. The matrix never changes. Aim for O(1) queries.

Constraints: 1 to 200 rows and columns, values in [-10,000,10,000]; at most 10,000 queries.

Example: `[[1,2],[3,4]]`, query `(0,0,1,1)` returns `10`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/304-range-sum-query-2d-immutable/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
