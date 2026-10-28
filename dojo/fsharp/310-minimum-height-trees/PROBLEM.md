# Drill 310: Minimum Height Trees

LeetCode Medium: https://leetcode.com/problems/minimum-height-trees/

Given an undirected tree on nodes 0 through n-1, return all root choices that minimize the resulting rooted tree's height. Return roots in any order.

Constraints: 1 to 20,000 nodes; exactly n-1 undirected edges forming a tree.

Example: `4, [[1,0],[1,2],[1,3]]` returns `[1]`. Implement `FindMinHeightTrees(int n, int[][] edges)` returning `IList<int>`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/310-minimum-height-trees/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
