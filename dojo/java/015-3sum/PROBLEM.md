# Drill 015: 3Sum

LeetCode Medium: https://leetcode.com/problems/3sum/

Return all unique value triplets whose sum is zero, using three distinct indices. Triplet order and result order do not matter. You may sort the input.

Constraints: 3 to 3000 integers between -100,000 and 100,000.

Example: `[-1,0,1,2,-1,-4]` returns `[[-1,-1,2],[-1,0,1]]`. Implement `ThreeSum(int[] nums)` returning `IList<IList<int>>`.

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
java\run-all.ps1 -Drill 015-3sum
```

To test the completed reference instead of your solution, add `--reference`.
