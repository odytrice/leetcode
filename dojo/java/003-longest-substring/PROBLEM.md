# Drill 003: Longest Substring Without Repeating Characters

Difficulty: LeetCode Medium (problem 3).

https://leetcode.com/problems/longest-substring-without-repeating-characters/

Given a string `s`, return the length of its longest substring without repeating characters.

A substring is contiguous. You cannot skip characters.

For this drill, the input contains ASCII characters only, including letters, digits, spaces and punctuation. Comparisons are case-sensitive.

## Examples

```text
Input: "abcabcbb"
Output: 3
Explanation: "abc" has length 3 and no repeating characters.
```

```text
Input: "bbbbb"
Output: 1
Explanation: "b" has length 1.
```

```text
Input: "pwwkew"
Output: 3
Explanation: "wke" is a valid substring. "pwke" is not contiguous.
```

## Constraints

- `0 <= s.Length <= 50_000`
- Input is non-null.
- ASCII characters only for this drill.

## Your task

Implement the stubs in `Solution.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 003-longest-substring
```

To test the completed reference instead of your solution, add `--reference`.
