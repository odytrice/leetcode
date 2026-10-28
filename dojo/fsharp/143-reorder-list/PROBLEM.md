# Drill 143: Reorder List

LeetCode Medium: https://leetcode.com/problems/reorder-list/

Reorder nodes in place as L0, Ln, L1, Ln-1, L2, Ln-2, and so on. Change links, not values. The method returns void.

Constraints: 1 to 50,000 nodes. `ListNode` is supplied.

Example: `[1,2,3,4,5]` becomes `[1,5,2,4,3]`. Implement `ReorderList(ListNode head)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/143-reorder-list/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
