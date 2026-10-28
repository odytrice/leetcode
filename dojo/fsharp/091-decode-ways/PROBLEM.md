# Drill 091: Decode Ways

LeetCode Medium: https://leetcode.com/problems/decode-ways/

Count ways to decode digits using 1=A through 26=Z. A code cannot start with zero; zero is valid only within 10 or 20. Return 0 when decoding is impossible.

Constraints: 1 to 100 digits; answer fits signed int.

Example: `"226"` returns `3`; `"06"` returns `0`. Implement `NumDecodings(string s)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/091-decode-ways/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
