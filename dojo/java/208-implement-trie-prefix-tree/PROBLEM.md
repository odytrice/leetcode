# Drill 208: Implement Trie (Prefix Tree)

LeetCode Medium: https://leetcode.com/problems/implement-trie-prefix-tree/

Implement `Trie()`, `Insert(string word)`, `Search(string word)` for exact inserted words, and `StartsWith(string prefix)` for prefixes of inserted words. Repeated insertion is allowed.

Constraints: nonempty lowercase words and prefixes of length <= 2000; at most 30,000 operations.

Example: insert "apple"; search "apple" -> true; search "app" -> false; startsWith "app" -> true.

## Your task

Implement the stubs in `Trie.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 208-implement-trie-prefix-tree
```

To test the completed reference instead of your solution, add `--reference`.
