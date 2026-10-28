# Drill 057: Insert Interval

LeetCode Medium: https://leetcode.com/problems/insert-interval/

Insert newInterval into sorted, nonoverlapping closed intervals. Merge overlapping or touching intervals and return the result sorted by start.

Constraints: 0 to 10,000 intervals; 0 <= start <= end <= 100,000.

Example: `[[1,3],[6,9]], [2,5]` returns `[[1,5],[6,9]]`. Implement `Insert(int[][] intervals, int[] newInterval)`.

## Your task

Implement the stubs in `solution.ts` using TypeScript without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
node test_solution.ts
```

Or from the `dojo` root:

```powershell
node typescript/057-insert-interval/test_solution.ts
```

To test the completed reference instead of your solution, add `--reference`.
