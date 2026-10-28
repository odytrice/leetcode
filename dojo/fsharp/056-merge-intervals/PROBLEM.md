# Drill 056: Merge Intervals

Difficulty: LeetCode Medium (problem 56).

https://leetcode.com/problems/merge-intervals/

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

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/056-merge-intervals/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
