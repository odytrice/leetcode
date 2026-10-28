# Drill 039: Combination Sum

LeetCode Medium: https://leetcode.com/problems/combination-sum/

Return all unique combinations of distinct positive candidate values summing to target. Each candidate may be reused unlimited times. Ignore ordering of combinations and their members.

Constraints: 1 to 30 candidates in [2,40]; target 1 to 40; fewer than 150 answers.

Example: `[2,3,6,7], 7` returns `[[2,2,3],[7]]`. Implement `CombinationSum(int[] candidates, int target)` returning `IList<IList<int>>`.

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
java\run-all.ps1 -Drill 039-combination-sum
```

To test the completed reference instead of your solution, add `--reference`.
