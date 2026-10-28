# Drill 098: Validate Binary Search Tree

LeetCode Medium: https://leetcode.com/problems/validate-binary-search-tree/

Return whether every node's left subtree contains only smaller values and its right subtree only larger values. Duplicates are invalid. Bounds apply to the entire subtree, not just direct children.

Constraints: 1 to 10,000 nodes with signed 32-bit values. `TreeNode` is supplied.

Example: `[5,1,4,null,null,3,6]` is invalid. Implement `IsValidBST(TreeNode? root)`.

## Your task

Implement the stubs in `solution.py` using Python without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
python test_solution.py
```

Or from the `dojo` root:

```powershell
python python/098-validate-binary-search-tree/test_solution.py
```

To test the completed reference instead of your solution, add `--reference`.
