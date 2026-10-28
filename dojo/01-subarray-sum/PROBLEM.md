# Drill 01: Subarray Sum Equals K

Difficulty: LeetCode Medium (problem 560).

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

Implement `Solution.SubarraySum(int[] nums, int k)` in `Solution.cs` using C# without external libraries.

Before coding, explain your understanding and proposed approach in chat. A straightforward correct approach is a valid starting point; consider whether it will scale to the constraints.

Run tests from this folder:

```powershell
dotnet run
```

Or from the `dojo` root:

```powershell
dotnet run --project 01-subarray-sum
```

The supplied tests are a starting point, not a complete assessment. Add cases you think matter. Be ready to explain why your algorithm counts every qualifying subarray exactly once and give its time and space complexity.
