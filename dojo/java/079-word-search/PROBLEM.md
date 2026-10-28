# Drill 079: Word Search

LeetCode Medium: https://leetcode.com/problems/word-search/

Return whether word can be formed by a path of horizontally or vertically adjacent cells. A cell cannot be reused within a path. Restore any temporary board changes before returning.

Constraints: 1 to 6 rows and columns; word length 1 to 15; letters are case-sensitive.

Example: board `["ABCE","SFCS","ADEE"]`, word `"ABCCED"` returns true. Implement `Exist(char[][] board, string word)`.

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
java\run-all.ps1 -Drill 079-word-search
```

To test the completed reference instead of your solution, add `--reference`.
