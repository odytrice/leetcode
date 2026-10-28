# Drill 1046: Last Stone Weight

LeetCode Easy: https://leetcode.com/problems/last-stone-weight/

Repeatedly smash the two heaviest stones. Equal weights both disappear; otherwise replace them with their positive difference. Return the final weight, or 0 if none remain.

Constraints: 1 to 30 stones, weights 1 to 1000.

Example: `[2,7,4,1,8,1]` returns `1`. Implement `LastStoneWeight(int[] stones)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/1046-last-stone-weight/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
