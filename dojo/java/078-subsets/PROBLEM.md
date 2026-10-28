# Drill 078: Subsets

LeetCode Medium: https://leetcode.com/problems/subsets/

Return every subset of an array of distinct integers, including the empty subset. No duplicate subsets; any order is accepted.

Constraints: 1 to 10 integers in [-10,10].

Example: `[1,2]` returns `[[],[1],[2],[1,2]]`. Implement `Subsets(int[] nums)` returning `IList<IList<int>>`.

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
java\run-all.ps1 -Drill 078-subsets
```

To test the completed reference instead of your solution, add `--reference`.
