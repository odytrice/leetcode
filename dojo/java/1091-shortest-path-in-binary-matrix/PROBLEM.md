# Drill 1091: Shortest Path in Binary Matrix

LeetCode Medium: https://leetcode.com/problems/shortest-path-in-binary-matrix/

In a square binary grid, 0 is clear and 1 blocked. Find the shortest clear path from top-left to bottom-right using **eight directions**, including diagonals. Return number of cells on the path, or -1. You may modify the grid.

Constraints: square size 1 to 100.

Example: `[[0,1],[1,0]]` returns `2`. Implement `ShortestPathBinaryMatrix(int[][] grid)`.

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
java\run-all.ps1 -Drill 1091-shortest-path-in-binary-matrix
```

To test the completed reference instead of your solution, add `--reference`.
