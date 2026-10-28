# Drill 046: Permutations

LeetCode Medium: https://leetcode.com/problems/permutations/

Return every permutation of an array of distinct integers. Any order of results is accepted, but order within each permutation matters.

Constraints: 1 to 6 integers in [-10,10].

Example: `[1,2]` returns `[[1,2],[2,1]]`. Implement `Permute(int[] nums)` returning `IList<IList<int>>`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/046-permutations/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
