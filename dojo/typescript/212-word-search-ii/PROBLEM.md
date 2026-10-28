# Drill 212: Word Search II

LeetCode Hard: https://leetcode.com/problems/word-search-ii/

Return all dictionary words that can be spelled by horizontal or vertical paths through a letter board. A cell may be used once per word path. Return each found word once, in any order. Restore temporary board changes.

Constraints: 1 to 12 rows and columns; up to 30,000 distinct lowercase words of length 1 to 10.

Example: board `["ab","cd"]`, words `["ab","ac","ad"]` returns `["ab","ac"]`. Implement `FindWords(char[][] board, string[] words)` returning `IList<string>`.

## Your task

Implement the stubs in `solution.ts` using TypeScript without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
node test_solution.ts
```

Or from the `dojo` root:

```powershell
node typescript/212-word-search-ii/test_solution.ts
```

To test the completed reference instead of your solution, add `--reference`.
