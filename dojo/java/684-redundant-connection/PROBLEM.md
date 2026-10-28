# Drill 684: Redundant Connection

LeetCode Medium: https://leetcode.com/problems/redundant-connection/

An undirected tree labeled 1 through n gained one extra edge. Return an edge whose removal restores a tree. If multiple are possible, return the one appearing last in the input, preserving its endpoint order.

Constraints: 3 to 1000 nodes; exactly n distinct undirected edges; no self-loops.

Example: `[[1,2],[1,3],[2,3]]` returns `[2,3]`. Implement `FindRedundantConnection(int[][] edges)`.

## Your task

Implement the stubs in `Solution.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 684-redundant-connection
```

To test the completed reference instead of your solution, add `--reference`.
