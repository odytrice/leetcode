# Drill 236: Lowest Common Ancestor of a Binary Tree

LeetCode Medium: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/

Return the deepest node that is an ancestor of both p and q. A node is its own ancestor. p and q are distinct original nodes present in the tree; return an original node.

Constraints: 2 to 100,000 nodes with unique values. `TreeNode` is supplied.

Example: root 3 with children 5 and 1 has LCA(5,1) = root. Implement `LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)`.

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
java\run-all.ps1 -Drill 236-lowest-common-ancestor-of-a-binary-tree
```

To test the completed reference instead of your solution, add `--reference`.
