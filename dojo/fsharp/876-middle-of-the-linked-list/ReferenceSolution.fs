module ReferenceSolution

open Models

// O(n) time, O(1) space. The fast pointer travels twice as far.
let middleNode (head: ListNode) : ListNode =
    let mutable slow = head
    let mutable fast = Some head
    while fast.IsSome && fast.Value.Next.IsSome do
        slow <- slow.Next.Value
        fast <- fast.Value.Next.Value.Next
    slow
