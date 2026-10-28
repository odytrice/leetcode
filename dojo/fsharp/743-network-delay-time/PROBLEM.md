# Drill 743: Network Delay Time

LeetCode Medium: https://leetcode.com/problems/network-delay-time/

Directed edges `[u,v,w]` take w time units. Nodes are 1 through n. A signal begins at k at time zero. Return the earliest time every node has received it, or -1 if some node is unreachable.

Constraints: 1 to 100 nodes; up to 6000 distinct directed edges; weights 0 to 100.

Example: `[[2,1,1],[2,3,1],[3,4,1]], 4, 2` returns `2`. Implement `NetworkDelayTime(int[][] times, int n, int k)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/743-network-delay-time/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
