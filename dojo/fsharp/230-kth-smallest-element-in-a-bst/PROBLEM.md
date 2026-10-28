# Drill 230: Kth Smallest Element in a BST

LeetCode Medium: https://leetcode.com/problems/kth-smallest-element-in-a-bst/

Return the kth smallest value in a binary search tree, with k counted from one.

Constraints: 1 to 10,000 nodes; 1 <= k <= node count. `TreeNode` is supplied.

Example: `[3,1,4,null,2], 1` returns `1`. Implement `KthSmallest(TreeNode root, int k)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/230-kth-smallest-element-in-a-bst/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
