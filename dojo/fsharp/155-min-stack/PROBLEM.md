# Drill 155: Min Stack

LeetCode Medium: https://leetcode.com/problems/min-stack/

All operations must be O(1). Top, pop, and minimum queries occur only on nonempty stacks.

Constraints: signed 32-bit values; at most 30,000 operations.

Example: push -2, 0, -3; minimum is -3; pop; top is 0 and minimum is -2.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/155-min-stack/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
