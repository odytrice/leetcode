module ReferenceSolution

open Models

// O(n) time, O(1) space. Splits at the middle, reverses the tail, then merges.
let reorderList (head: ListNode) : unit =
    let mutable slow = head
    let mutable fast = head
    while fast.Next.IsSome && fast.Next.Value.Next.IsSome do
        slow <- slow.Next.Value
        fast <- fast.Next.Value.Next.Value

    let mutable right = slow.Next
    slow.Next <- None
    let mutable reversedTail: ListNode option = None
    while right.IsSome do
        let node = right.Value
        let following = node.Next
        node.Next <- reversedTail
        reversedTail <- Some node
        right <- following

    let mutable left = Some head
    while reversedTail.IsSome do
        let leftNode = left.Value
        let nextLeft = leftNode.Next
        let nextRight = reversedTail.Value.Next
        leftNode.Next <- reversedTail
        reversedTail.Value.Next <- nextLeft
        left <- nextLeft
        reversedTail <- nextRight