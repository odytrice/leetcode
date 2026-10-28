# Drill 131: Palindrome Partitioning

LeetCode Medium: https://leetcode.com/problems/palindrome-partitioning/

Partition s into contiguous nonempty substrings so every substring is a palindrome. Return every valid partition, in any outer order; keep substrings in original order.

Constraints: 1 to 16 lowercase letters.

Example: `"aab"` returns `[["a","a","b"],["aa","b"]]`. Implement `Partition(string s)` returning `IList<IList<string>>`.

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
java\run-all.ps1 -Drill 131-palindrome-partitioning
```

To test the completed reference instead of your solution, add `--reference`.
