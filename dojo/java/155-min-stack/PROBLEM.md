# Drill 155: Min Stack

LeetCode Medium: https://leetcode.com/problems/min-stack/

All operations must be O(1). Top, pop, and minimum queries occur only on nonempty stacks.

Constraints: signed 32-bit values; at most 30,000 operations.

Example: push -2, 0, -3; minimum is -3; pop; top is 0 and minimum is -2.

## Your task

Implement the stubs in `MinStack.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 155-min-stack
```

To test the completed reference instead of your solution, add `--reference`.
