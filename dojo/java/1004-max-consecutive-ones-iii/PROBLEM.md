# Drill 1004: Max Consecutive Ones III

LeetCode Medium: https://leetcode.com/problems/max-consecutive-ones-iii/

Given a binary array, return the longest contiguous run of ones obtainable by flipping at most k zeros.

Constraints: 1 to 100,000 elements; 0 <= k <= nums.Length.

Example: `[1,1,1,0,0,0,1,1,1,1,0], 2` returns `6`. Implement `LongestOnes(int[] nums, int k)`.

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
java\run-all.ps1 -Drill 1004-max-consecutive-ones-iii
```

To test the completed reference instead of your solution, add `--reference`.
