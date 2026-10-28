# Drill 417: Pacific Atlantic Water Flow

LeetCode Medium: https://leetcode.com/problems/pacific-atlantic-water-flow/

Water flows horizontally or vertically from a cell to equal or lower height. The Pacific touches the top and left edges; the Atlantic touches the bottom and right. Return coordinates from which water can reach both oceans, in any order.

Constraints: 1 to 200 rows and columns, heights 0 to 100,000.

Example: `[[1,2],[4,3]]` returns `[[0,1],[1,0],[1,1]]`. Implement `PacificAtlantic(int[][] heights)` returning `IList<IList<int>>`.

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
java\run-all.ps1 -Drill 417-pacific-atlantic-water-flow
```

To test the completed reference instead of your solution, add `--reference`.
