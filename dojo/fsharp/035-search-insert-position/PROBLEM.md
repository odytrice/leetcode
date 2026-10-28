# Drill 035: Search Insert Position

LeetCode Easy: https://leetcode.com/problems/search-insert-position/

Given a strictly increasing array, return the index of target, or the insertion position that preserves sorting. Required time: O(log n).

Constraints: 1 to 10,000 elements; values and target in [-10,000,10,000].

Example: `[1,3,5,6], 2` returns `1`. Implement `SearchInsert(int[] nums, int target)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/035-search-insert-position/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
