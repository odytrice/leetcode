module ReferenceSolution

open Models

// O(n) time, O(1) space. A lead of n nodes puts slow on the node before the target.
let removeNthFromEnd (head: ListNode) (n: int) : ListNode option =
    let dummy = ListNode(0, Some head)
    let mutable fast: ListNode option = Some dummy
    let mutable slow = dummy
    for _ in 0 .. n do
        fast <- fast.Value.Next
    while fast.IsSome do
        fast <- fast.Value.Next
        slow <- slow.Next.Value
    slow.Next <- slow.Next.Value.Next
    dummy.Next
