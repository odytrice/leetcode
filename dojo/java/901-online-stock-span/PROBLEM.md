# Drill 901: Online Stock Span

LeetCode Medium: https://leetcode.com/problems/online-stock-span/

Each call appends today's price and returns the number of consecutive days ending today whose prices are <= today's.

Constraints: prices in [1,100,000]; at most 10,000 calls.

Example: prices `[100,80,60,70,60,75,85]` produce `[1,1,1,2,1,4,6]`.

## Your task

Implement the stubs in `StockSpanner.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 901-online-stock-span
```

To test the completed reference instead of your solution, add `--reference`.
