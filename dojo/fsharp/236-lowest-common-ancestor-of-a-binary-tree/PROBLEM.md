# Drill 236: Lowest Common Ancestor of a Binary Tree

LeetCode Medium: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/

Return the deepest node that is an ancestor of both p and q. A node is its own ancestor. p and q are distinct original nodes present in the tree; return an original node.

Constraints: 2 to 100,000 nodes with unique values. `TreeNode` is supplied.

Example: root 3 with children 5 and 1 has LCA(5,1) = root. Implement `LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/236-lowest-common-ancestor-of-a-binary-tree/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
