# Drill 04: Daily Temperatures

Difficulty: LeetCode Medium (problem 739).

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

Implement `Solution.DailyTemperatures(int[] temperatures)` in `Solution.cs`.

Explain your approach before coding. A straightforward correct approach is a valid starting point; consider whether it scales to the constraints. Add your own test cases and explain time and space complexity.

From this folder:

```powershell
dotnet run
```

From the `dojo` root:

```powershell
dotnet run --project 04-daily-temperatures
```
