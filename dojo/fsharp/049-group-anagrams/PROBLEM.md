# Drill 049: Group Anagrams

LeetCode Medium: https://leetcode.com/problems/group-anagrams/

Group strings that contain the same letters with the same multiplicities. Any order of groups and members is accepted; preserve duplicates.

Constraints: 1 to 10,000 strings, each 0 to 100 lowercase English letters.

Example: `["eat","tea","tan","ate","nat","bat"]` gives `[["eat","tea","ate"],["tan","nat"],["bat"]]`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/049-group-anagrams/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
