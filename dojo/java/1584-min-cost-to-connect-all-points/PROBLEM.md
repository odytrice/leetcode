# Drill 1584: Min Cost to Connect All Points

LeetCode Medium: https://leetcode.com/problems/min-cost-to-connect-all-points/

Connect all points so there is exactly one simple path between any two points. Connecting points costs their Manhattan distance `abs(x1-x2)+abs(y1-y2)`. Return the minimum total cost.

Constraints: 1 to 1000 distinct points; coordinates in [-1,000,000,1,000,000].

Example: `[[0,0],[2,2],[3,10],[5,2],[7,0]]` returns `20`. Implement `MinCostConnectPoints(int[][] points)`.

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
java\run-all.ps1 -Drill 1584-min-cost-to-connect-all-points
```

To test the completed reference instead of your solution, add `--reference`.
