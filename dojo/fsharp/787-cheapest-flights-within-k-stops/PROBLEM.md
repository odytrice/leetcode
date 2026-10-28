# Drill 787: Cheapest Flights Within K Stops

LeetCode Medium: https://leetcode.com/problems/cheapest-flights-within-k-stops/

Flights are directed `[from,to,price]`. Return the cheapest cost from src to dst with at most k intermediate stops, meaning at most k+1 edges. Return -1 if impossible.

Constraints: 2 to 100 cities numbered from zero; distinct flights; prices 1 to 10,000; 0 <= k < n; src != dst.

Example: `n=3, [[0,1,100],[1,2,100],[0,2,500]], src=0, dst=2, k=1` returns `200`. Implement `FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/787-cheapest-flights-within-k-stops/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
