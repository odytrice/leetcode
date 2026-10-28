# Drill 763: Partition Labels

LeetCode Medium: https://leetcode.com/problems/partition-labels/

Split s into as many contiguous parts as possible so every letter occurs in at most one part. Return the part lengths in original order.

Constraints: 1 to 500 lowercase letters.

Example: `"ababcbacadefegdehijhklij"` returns `[9,7,8]`. Implement `PartitionLabels(string s)` returning `IList<int>`.

## Your task

Implement the stubs in `Solution.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 763-partition-labels
```

To test the completed reference instead of your solution, add `--reference`.
