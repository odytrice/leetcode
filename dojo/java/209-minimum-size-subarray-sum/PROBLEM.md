# Drill 209: Minimum Size Subarray Sum

LeetCode Medium: https://leetcode.com/problems/minimum-size-subarray-sum/

Return the shortest length of a contiguous subarray with sum at least target. Return 0 if none exists. All numbers are positive.

Constraints: 1 to 100,000 elements; values 1 to 10,000; target 1 to 1e9.

Example: `7, [2,3,1,2,4,3]` returns `2`. Implement `MinSubArrayLen(int target, int[] nums)`.

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
java\run-all.ps1 -Drill 209-minimum-size-subarray-sum
```

To test the completed reference instead of your solution, add `--reference`.
