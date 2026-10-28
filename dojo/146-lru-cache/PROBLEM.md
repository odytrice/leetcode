# Drill 146: LRU Cache

LeetCode Medium: https://leetcode.com/problems/lru-cache/

Implement `LRUCache(int capacity)`, `Get(int key)`, and `Put(int key, int value)` in average O(1). Get returns -1 for missing keys; successful gets and all puts mark the key most recently used. At capacity, inserting a new key evicts the least recently used key.

Constraints: capacity 1 to 3000, nonnegative keys and values, at most 200,000 operations.

Example: capacity 2; put (1,1), (2,2); get 1; put (3,3); get 2 returns -1.
