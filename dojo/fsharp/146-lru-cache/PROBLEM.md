# Drill 146: LRU Cache

LeetCode Medium: https://leetcode.com/problems/lru-cache/

Implement `LRUCache(int capacity)`, `Get(int key)`, and `Put(int key, int value)` in average O(1). Get returns -1 for missing keys; successful gets and all puts mark the key most recently used. At capacity, inserting a new key evicts the least recently used key.

Constraints: capacity 1 to 3000, nonnegative keys and values, at most 200,000 operations.

Example: capacity 2; put (1,1), (2,2); get 1; put (3,3); get 2 returns -1.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/146-lru-cache/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
