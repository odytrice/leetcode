# Drill 090: Subsets II

LeetCode Medium: https://leetcode.com/problems/subsets-ii/

Return every distinct subset of nums, which may contain duplicate values. Include the empty subset. Multiplicity within a subset cannot exceed the input. Ignore result and member ordering.

Constraints: 1 to 10 integers in [-10,10]. You may sort the input.

Example: `[1,2,2]` returns `[[],[1],[2],[1,2],[2,2],[1,2,2]]`. Implement `SubsetsWithDup(int[] nums)` returning `IList<IList<int>>`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/090-subsets-ii/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
