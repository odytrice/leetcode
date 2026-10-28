# Drill 547: Number of Provinces

LeetCode Medium: https://leetcode.com/problems/number-of-provinces/

Given a symmetric city-connectivity matrix, return the number of connected components. Direct or indirect connections place cities in the same province. Diagonal entries are 1.

Constraints: 1 to 200 cities, binary square matrix.

Example: `[[1,1,0],[1,1,0],[0,0,1]]` returns `2`. Implement `FindCircleNum(int[][] isConnected)`.

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
java\run-all.ps1 -Drill 547-number-of-provinces
```

To test the completed reference instead of your solution, add `--reference`.
