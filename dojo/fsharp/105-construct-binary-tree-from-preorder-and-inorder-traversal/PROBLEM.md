# Drill 105: Construct Binary Tree from Preorder and Inorder Traversal

LeetCode Medium: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

Reconstruct the unique binary tree from its preorder and inorder arrays. Both contain the same distinct values and describe a valid tree.

Constraints: 1 to 3000 values in [-3000,3000]. `TreeNode` is supplied.

Example: `[3,9,20,15,7]`, `[9,3,15,20,7]` produces `[3,9,20,null,null,15,7]`. Implement `BuildTree(int[] preorder, int[] inorder)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/105-construct-binary-tree-from-preorder-and-inorder-traversal/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
