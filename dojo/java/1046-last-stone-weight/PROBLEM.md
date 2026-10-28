# Drill 1046: Last Stone Weight

LeetCode Easy: https://leetcode.com/problems/last-stone-weight/

Repeatedly smash the two heaviest stones. Equal weights both disappear; otherwise replace them with their positive difference. Return the final weight, or 0 if none remain.

Constraints: 1 to 30 stones, weights 1 to 1000.

Example: `[2,7,4,1,8,1]` returns `1`. Implement `LastStoneWeight(int[] stones)`.

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
java\run-all.ps1 -Drill 1046-last-stone-weight
```

To test the completed reference instead of your solution, add `--reference`.
