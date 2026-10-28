# Drill 802: Find Eventual Safe States

LeetCode Medium: https://leetcode.com/problems/find-eventual-safe-states/

graph[i] lists outgoing neighbors of i. A terminal node has no outgoing edges. A safe node is one from which every possible path eventually reaches a terminal node. Return all safe nodes in ascending order.

Constraints: 1 to 10,000 nodes; up to 40,000 edges; self-loops allowed.

Example: `[[1,2],[2,3],[5],[0],[5],[],[]]` returns `[2,4,5,6]`. Implement `EventualSafeNodes(int[][] graph)` returning `IList<int>`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/802-find-eventual-safe-states/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
