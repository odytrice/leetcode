# Drill 019: Remove Nth Node From End of List

LeetCode Medium: https://leetcode.com/problems/remove-nth-node-from-end-of-list/

Remove the nth node counted from the end of a singly linked list and return the new head. Aim for one pass. Preserve the remaining nodes.

Constraints: 1 to 30 nodes; 1 <= n <= node count. `ListNode` is supplied.

Example: `[1,2,3,4,5], 2` returns `[1,2,3,5]`. Implement `RemoveNthFromEnd(ListNode head, int n)`.

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
java\run-all.ps1 -Drill 019-remove-nth-node-from-end-of-list
```

To test the completed reference instead of your solution, add `--reference`.
