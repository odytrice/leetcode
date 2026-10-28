# Drill 322: Coin Change

LeetCode Medium: https://leetcode.com/problems/coin-change/

Return the fewest coins needed to make amount, or -1 if impossible. Each positive denomination can be used unlimited times. Amount zero requires zero coins.

Constraints: 1 to 12 denominations, each up to int.MaxValue; amount 0 to 10,000.

Example: `[1,2,5], 11` returns `3`. Implement `CoinChange(int[] coins, int amount)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/322-coin-change/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
