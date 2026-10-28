# Drill 743: Network Delay Time

LeetCode Medium: https://leetcode.com/problems/network-delay-time/

Directed edges `[u,v,w]` take w time units. Nodes are 1 through n. A signal begins at k at time zero. Return the earliest time every node has received it, or -1 if some node is unreachable.

Constraints: 1 to 100 nodes; up to 6000 distinct directed edges; weights 0 to 100.

Example: `[[2,1,1],[2,3,1],[3,4,1]], 4, 2` returns `2`. Implement `NetworkDelayTime(int[][] times, int n, int k)`.
