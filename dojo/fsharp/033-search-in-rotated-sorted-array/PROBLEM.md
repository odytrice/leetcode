# Drill 033: Search in Rotated Sorted Array

LeetCode Medium: https://leetcode.com/problems/search-in-rotated-sorted-array/

A strictly increasing array may have been rotated. Return target's index, or -1 if absent, in O(log n) time.

Constraints: 1 to 5000 unique values in [-10,000,10,000].

Example: `[4,5,6,7,0,1,2], 0` returns `4`. Implement `Search(int[] nums, int target)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/033-search-in-rotated-sorted-array/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
