# Drill 739: Daily Temperatures

Difficulty: LeetCode Medium (problem 739).

https://leetcode.com/problems/daily-temperatures/

Given an array of daily temperatures, return an array where each entry tells you how many days you must wait after that day for a strictly warmer temperature.

If no warmer day occurs later, use `0` for that entry. Equal temperatures do not count as warmer.

## Examples

```text
Input:  [73, 74, 75, 71, 69, 72, 76, 73]
Output: [ 1,  1,  4,  2,  1,  1,  0,  0]
```

For day 2 (temperature 75), the next warmer day is day 6 (temperature 76), so the wait is 4 days.

```text
Input:  [30, 40, 50, 60]
Output: [ 1,  1,  1,  0]
```

```text
Input:  [30, 60, 90]
Output: [ 1,  1,  0]
```

## Constraints

- `1 <= temperatures.Length <= 100_000`
- `30 <= temperatures[i] <= 100`
- Input is non-null.
- Return the number of days to wait, not the future temperature.

## Your task

Implement the stubs in `solution.ts` using TypeScript without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
node test_solution.ts
```

Or from the `dojo` root:

```powershell
node typescript/739-daily-temperatures/test_solution.ts
```

To test the completed reference instead of your solution, add `--reference`.
