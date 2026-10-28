# Drill 303: Range Sum Query: Immutable

LeetCode Easy: https://leetcode.com/problems/range-sum-query-immutable/

Implement `NumArray(int[] nums)` and `SumRange(int left, int right)`, returning the inclusive range sum. The array never changes. Queries use valid zero-based indices.

Constraints: 1 to 10,000 elements in [-100,000,100,000]; at most 10,000 queries.

Example: nums `[-2,0,3,-5,2,-1]`, query `(0,2)` returns `1`.

## Your task

Implement the stubs in `NumArray.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 303-range-sum-query-immutable
```

To test the completed reference instead of your solution, add `--reference`.
