# Drill 215: Kth Largest Element in an Array

LeetCode Medium: https://leetcode.com/problems/kth-largest-element-in-an-array/

Return the kth largest value, counting duplicates as separate elements, not the kth distinct value. Aim for a solution without fully sorting.

Constraints: 1 to 100,000 elements in [-10,000,10,000]; valid one-based k.

Example: `[3,2,1,5,6,4], 2` returns `5`. Implement `FindKthLargest(int[] nums, int k)`.

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
java\run-all.ps1 -Drill 215-kth-largest-element-in-an-array
```

To test the completed reference instead of your solution, add `--reference`.
