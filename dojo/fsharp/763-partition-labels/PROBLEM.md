# Drill 763: Partition Labels

LeetCode Medium: https://leetcode.com/problems/partition-labels/

Split s into as many contiguous parts as possible so every letter occurs in at most one part. Return the part lengths in original order.

Constraints: 1 to 500 lowercase letters.

Example: `"ababcbacadefegdehijhklij"` returns `[9,7,8]`. Implement `PartitionLabels(string s)` returning `IList<int>`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/763-partition-labels/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
