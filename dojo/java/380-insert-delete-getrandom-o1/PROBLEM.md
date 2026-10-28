# Drill 380: Insert Delete GetRandom O(1)

LeetCode Medium: https://leetcode.com/problems/insert-delete-getrandom-o1/

Implement `RandomizedSet()`, `Insert(int val)` (true if newly inserted), `Remove(int val)` (true if present), and `GetRandom()` (uniformly random current member). All operations require average O(1) time. GetRandom is called only when nonempty.

Constraints: signed 32-bit values; at most 200,000 operations.

Example: insert 1 -> true; insert 1 -> false; remove 1 -> true.

## Your task

Implement the stubs in `RandomizedSet.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 380-insert-delete-getrandom-o1
```

To test the completed reference instead of your solution, add `--reference`.
