# Drill 523: Continuous Subarray Sum

LeetCode Medium: https://leetcode.com/problems/continuous-subarray-sum/

Return whether any contiguous subarray of length at least two has a sum that is a multiple of positive k. Zero is a multiple of k.

Constraints: 1 to 100,000 nonnegative integers; k in [1, int.MaxValue]; total sum fits int.

Example: `[23,2,4,6,7], 6` returns `true`. Implement `CheckSubarraySum(int[] nums, int k)`.

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
java\run-all.ps1 -Drill 523-continuous-subarray-sum
```

To test the completed reference instead of your solution, add `--reference`.
