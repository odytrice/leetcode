# Drill 973: K Closest Points to Origin

LeetCode Medium: https://leetcode.com/problems/k-closest-points-to-origin/

Return the k input points with smallest Euclidean distance to (0,0), in any order. The answer is unique apart from ordering. Preserve multiplicity of identical input points.

Constraints: 1 to 10,000 points, coordinates in [-10,000,10,000]; valid k.

Example: `[[1,3],[-2,2]], 1` returns `[[-2,2]]`. Implement `KClosest(int[][] points, int k)`.

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
java\run-all.ps1 -Drill 973-k-closest-points-to-origin
```

To test the completed reference instead of your solution, add `--reference`.
