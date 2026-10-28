module ReferenceSolution

open Models

// O(n) time, O(1) space. Points each node at the previous one.
let reverseList (head: ListNode option) : ListNode option =
    let mutable previous = None
    let mutable current = head
    while current.IsSome do
        let node = current.Value
        let following = node.Next
        node.Next <- previous
        previous <- current
        current <- following
    previous
