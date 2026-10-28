# Drill 802: Find Eventual Safe States

LeetCode Medium: https://leetcode.com/problems/find-eventual-safe-states/

graph[i] lists outgoing neighbors of i. A terminal node has no outgoing edges. A safe node is one from which every possible path eventually reaches a terminal node. Return all safe nodes in ascending order.

Constraints: 1 to 10,000 nodes; up to 40,000 edges; self-loops allowed.

Example: `[[1,2],[2,3],[5],[0],[5],[],[]]` returns `[2,4,5,6]`. Implement `EventualSafeNodes(int[][] graph)` returning `IList<int>`.
