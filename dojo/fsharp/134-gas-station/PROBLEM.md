# Drill 134: Gas Station

LeetCode Medium: https://leetcode.com/problems/gas-station/

Stations form a circular route. At i you gain gas[i]; traveling to the next station costs cost[i]. Starting with an empty unlimited tank, return a valid start index for one full circuit, or -1. A valid answer, if it exists, is unique.

Constraints: equal array lengths 1 to 100,000; entries 0 to 10,000.

Example: `[1,2,3,4,5], [3,4,5,1,2]` returns `3`. Implement `CanCompleteCircuit(int[] gas, int[] cost)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/134-gas-station/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
