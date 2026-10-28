# Drill 394: Decode String

LeetCode Medium: https://leetcode.com/problems/decode-string/

Decode expressions where `k[encoded]` repeats the bracketed text k times. Expressions may nest. Input is valid and contains lowercase letters, brackets, and positive repeat counts.

Constraints: encoded length 1 to 30; counts 1 to 300; decoded length <= 100,000.

Example: `"3[a2[c]]"` returns `"accaccacc"`. Implement `DecodeString(string s)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/394-decode-string/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
