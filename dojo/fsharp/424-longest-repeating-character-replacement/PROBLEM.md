# Drill 424: Longest Repeating Character Replacement

LeetCode Medium: https://leetcode.com/problems/longest-repeating-character-replacement/

Replace at most k characters in an uppercase string with any uppercase letters. Return the longest possible contiguous run of one letter.

Constraints: 1 to 100,000 characters; 0 <= k <= s.Length.

Example: `"AABABBA", 1` returns `4`. Implement `CharacterReplacement(string s, int k)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/424-longest-repeating-character-replacement/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
