# Drill 034: Find First and Last Position of Element in Sorted Array

LeetCode Medium: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

Return the first and last indices of target in a nondecreasing array, or `[-1,-1]`. Required time: O(log n).

Constraints: 0 to 100,000 elements, values and target in [-1e9,1e9].

Example: `[5,7,7,8,8,10], 8` returns `[3,4]`. Implement `SearchRange(int[] nums, int target)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/034-find-first-and-last-position-of-element-in-sorted-array/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
