# Drill 199: Binary Tree Right Side View

LeetCode Medium: https://leetcode.com/problems/binary-tree-right-side-view/

Return the value visible from the right at each depth, top to bottom. A deeper left-subtree node can be visible when the right subtree ends.

Constraints: 0 to 100 nodes. `TreeNode` is supplied.

Example: `[1,2,3,null,5,null,4]` returns `[1,3,4]`. Implement `RightSideView(TreeNode? root)` returning `IList<int>`.

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
java\run-all.ps1 -Drill 199-binary-tree-right-side-view
```

To test the completed reference instead of your solution, add `--reference`.
