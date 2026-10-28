# Drill 102: Binary Tree Level Order Traversal

LeetCode Medium: https://leetcode.com/problems/binary-tree-level-order-traversal/

Return node values grouped by depth, from top to bottom, left to right within each level.

Constraints: 0 to 2000 nodes. `TreeNode` is supplied.

Example: `[3,9,20,null,null,15,7]` returns `[[3],[9,20],[15,7]]`. Implement `LevelOrder(TreeNode? root)` returning `IList<IList<int>>`.

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
java\run-all.ps1 -Drill 102-binary-tree-level-order-traversal
```

To test the completed reference instead of your solution, add `--reference`.
