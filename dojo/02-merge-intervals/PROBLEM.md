# Drill 02: Merge Intervals

Difficulty: LeetCode Medium (problem 56).

Given an array of intervals, where each interval is `[start, end]`, merge all overlapping intervals. Return the non-overlapping intervals that cover exactly the same values as the input.

Intervals include both endpoints. For example, `[1, 4]` and `[4, 5]` overlap and become `[1, 5]`.

The input is not necessarily ordered. You may modify the input. Return the result ordered by start value.

## Examples

```text
Input: [[1, 3], [2, 6], [8, 10], [15, 18]]
Output: [[1, 6], [8, 10], [15, 18]]
```

```text
Input: [[1, 4], [4, 5]]
Output: [[1, 5]]
```

```text
Input: [[8, 10], [1, 4], [2, 3]]
Output: [[1, 4], [8, 10]]
```

## Constraints

- `1 <= intervals.Length <= 10_000`
- Every interval contains exactly two integers.
- `0 <= start <= end <= 10_000`

## Your task

Implement `Solution.Merge(int[][] intervals)` in `Solution.cs`.

Explain your approach before coding. Add tests for any important cases you identify. Be ready to explain correctness and time and space complexity.

From this folder:

```powershell
dotnet run
```

From the `dojo` root:

```powershell
dotnet run --project 02-merge-intervals
```
