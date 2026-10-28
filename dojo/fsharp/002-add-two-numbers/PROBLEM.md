# Drill 002: Add Two Numbers

LeetCode Medium: https://leetcode.com/problems/add-two-numbers/

Two nonempty lists store nonnegative integers in reverse digit order. Return their sum as a reverse-order digit list. No leading zeros except the number zero itself.

Constraints: 1 to 100 nodes per list, values 0 to 9. Do not convert the entire list to a fixed-width integer. `ListNode` is supplied.

Example: `[2,4,3] + [5,6,4]` returns `[7,0,8]`. Implement `AddTwoNumbers(ListNode l1, ListNode l2)`.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/002-add-two-numbers/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
