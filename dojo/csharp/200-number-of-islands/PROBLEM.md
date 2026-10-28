# Drill 200: Number of Islands

Difficulty: LeetCode Medium (problem 200).

https://leetcode.com/problems/number-of-islands/

Given an `m x n` grid of characters, where `'1'` represents land and `'0'` represents water, return the number of islands.

An island is a group of land cells connected horizontally or vertically. Diagonal connections do not count. You may assume all four edges of the grid are surrounded by water.

## Examples

```text
Input: grid = [
  ['1', '1', '1', '1', '0'],
  ['1', '1', '0', '1', '0'],
  ['1', '1', '0', '0', '0'],
  ['0', '0', '0', '0', '0']
]
Output: 1
```

```text
Input: grid = [
  ['1', '1', '0', '0', '0'],
  ['1', '1', '0', '0', '0'],
  ['0', '0', '1', '0', '0'],
  ['0', '0', '0', '1', '1']
]
Output: 3
```

```text
Input: grid = [
  ['1', '0'],
  ['0', '1']
]
Output: 2
```

## Constraints

- `1 <= m, n <= 300`
- Every row has the same length.
- Each cell contains either `'0'` or `'1'`.
- The grid and its rows are non-null.
- You may modify the input grid.

## Your task

Implement `Solution.NumIslands(char[][] grid)` in `Solution.cs`.

Explain your approach before coding. Add your own tests and explain correctness, time complexity and space complexity.

From this folder:

```powershell
dotnet run
```

From the `dojo` root:

```powershell
dotnet run --project 200-number-of-islands
```
