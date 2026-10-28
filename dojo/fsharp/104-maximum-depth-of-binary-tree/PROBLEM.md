# Drill 104: Maximum Depth of Binary Tree

LeetCode Easy: https://leetcode.com/problems/maximum-depth-of-binary-tree/

Return the maximum number of nodes on a path from root to leaf. An empty tree has depth 0.

Constraints: 0 to 10,000 nodes. `TreeNode` is supplied; test arrays are level order with nulls for missing children.

Example: `[3,9,20,null,null,15,7]` returns `3`. Implement `MaxDepth(TreeNode? root)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/104-maximum-depth-of-binary-tree/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
