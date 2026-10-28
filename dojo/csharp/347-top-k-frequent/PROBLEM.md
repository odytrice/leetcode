# Drill 347: Top K Frequent Elements

Difficulty: LeetCode Medium (problem 347).

https://leetcode.com/problems/top-k-frequent-elements/

Given an integer array `nums` and an integer `k`, return the `k` distinct elements that occur most frequently.

You may return the elements in any order. The answer is guaranteed to be unique: there is no tie across the cutoff between included and excluded elements.

## Examples

```text
Input: nums = [1, 1, 1, 2, 2, 3], k = 2
Output: [1, 2]
```

```text
Input: nums = [1], k = 1
Output: [1]
```

```text
Input: nums = [4, 4, 4, -1, -1, 2], k = 2
Output: [4, -1]
```

## Constraints

- `1 <= nums.Length <= 100_000`
- `-10_000 <= nums[i] <= 10_000`
- `1 <= k <= number of distinct elements`
- Input is non-null.
- Return the elements themselves, not their frequencies.

## Your task

Implement `Solution.TopKFrequent(int[] nums, int k)` in `Solution.cs`.

Explain your approach before coding. Start with a correct solution, then consider how to achieve better than O(n log n) time, where n is the input length. Add your own tests and explain time and space complexity.

From this folder:

```powershell
dotnet run
```

From the `dojo` root:

```powershell
dotnet run --project 347-top-k-frequent
```
