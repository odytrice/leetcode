# Drill 994: Rotting Oranges

LeetCode Medium: https://leetcode.com/problems/rotting-oranges/

In a grid, 0 is empty, 1 is fresh, and 2 is rotten. Each minute all rotten oranges simultaneously rot fresh horizontal or vertical neighbors. Return minutes until no fresh orange remains, or -1 if impossible. You may modify the grid.

Constraints: 1 to 10 rows and columns.

Example: `[[2,1,1],[1,1,0],[0,1,1]]` returns `4`. Implement `OrangesRotting(int[][] grid)`.

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
java\run-all.ps1 -Drill 994-rotting-oranges
```

To test the completed reference instead of your solution, add `--reference`.
