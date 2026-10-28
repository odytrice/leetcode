# Drill 295: Find Median from Data Stream

LeetCode Hard: https://leetcode.com/problems/find-median-from-data-stream/

Return the middle value of all inserted values, or the mean of the two middle values for an even count. Queries occur only after an insertion. Aim for O(log n) insertion and O(1) queries.

Constraints: values in [-100,000,100,000]; at most 50,000 operations.

Example: insert 1,2 -> median 1.5; insert 3 -> median 2.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/295-find-median-from-data-stream/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
