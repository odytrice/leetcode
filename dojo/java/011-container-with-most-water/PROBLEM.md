# Drill 011: Container With Most Water

LeetCode Medium: https://leetcode.com/problems/container-with-most-water/

Vertical lines at integer positions have heights `height[i]`. Choose two lines to maximize contained water: width times the shorter height. Return that area.

Constraints: 2 to 100,000 heights, each 0 to 10,000.

Example: `[1,8,6,2,5,4,8,3,7]` returns `49`. Implement `MaxArea(int[] height)`.

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
java\run-all.ps1 -Drill 011-container-with-most-water
```

To test the completed reference instead of your solution, add `--reference`.
