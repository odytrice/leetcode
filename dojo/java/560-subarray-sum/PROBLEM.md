# Drill 560: Subarray Sum Equals K

Difficulty: LeetCode Medium (problem 560).

https://leetcode.com/problems/subarray-sum-equals-k/

Given an integer array `nums` and an integer `k`, return the number of non-empty, contiguous subarrays whose sum equals `k`.

A subarray consists of consecutive elements of the original array. Two subarrays with different start or end positions count separately, even if their values are identical.

## Examples

```text
Input: nums = [1, 1, 1], k = 2
Output: 2
Explanation: The subarrays at positions 0..1 and 1..2 each sum to 2.
```

```text
Input: nums = [1, 2, 3], k = 3
Output: 2
Explanation: [1, 2] and [3].
```

```text
Input: nums = [1, -1, 0], k = 0
Output: 3
Explanation: [1, -1], [0], and [1, -1, 0].
```

## Constraints

- `1 <= len(nums) <= 20_000`
- `-1_000 <= nums[i] <= 1_000`
- `-10_000_000 <= k <= 10_000_000`

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
java\run-all.ps1 -Drill 560-subarray-sum
```

To test the completed reference instead of your solution, add `--reference`.
