# Drill 901: Online Stock Span

LeetCode Medium: https://leetcode.com/problems/online-stock-span/

Implement `StockSpanner()` and `Next(int price)`. Each call appends today's price and returns the number of consecutive days ending today whose prices are <= today's.

Constraints: prices in [1,100,000]; at most 10,000 calls.

Example: prices `[100,80,60,70,60,75,85]` produce `[1,1,1,2,1,4,6]`.
