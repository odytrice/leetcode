# Drill 300: Longest Increasing Subsequence

LeetCode Medium: https://leetcode.com/problems/longest-increasing-subsequence/

Return the longest strictly increasing subsequence length. Elements need not be contiguous, but must retain their original order. Equal values do not extend it. Follow-up: O(n log n) time.

Constraints: 1 to 2500 integers in [-10,000,10,000].

Example: `[10,9,2,5,3,7,101,18]` returns `4`. Implement `LengthOfLIS(int[] nums)`.

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
java\run-all.ps1 -Drill 300-longest-increasing-subsequence
```

To test the completed reference instead of your solution, add `--reference`.
