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

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/200-number-of-islands/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
