# Drill 787: Cheapest Flights Within K Stops

LeetCode Medium: https://leetcode.com/problems/cheapest-flights-within-k-stops/

Flights are directed `[from,to,price]`. Return the cheapest cost from src to dst with at most k intermediate stops, meaning at most k+1 edges. Return -1 if impossible.

Constraints: 2 to 100 cities numbered from zero; distinct flights; prices 1 to 10,000; 0 <= k < n; src != dst.

Example: `n=3, [[0,1,100],[1,2,100],[0,2,500]], src=0, dst=2, k=1` returns `200`. Implement `FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)`.
