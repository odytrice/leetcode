module ReferenceSolution

open Models

// O(n) time, O(1) space. After the meeting, walks from the head and the meeting point.
let detectCycle (head: ListNode option) : ListNode option =
    let mutable slow = head
    let mutable fast = head
    let mutable answer: ListNode option = None
    let mutable searching = true

    while searching && fast.IsSome && fast.Value.Next.IsSome do
        slow <- slow.Value.Next
        fast <- fast.Value.Next.Value.Next
        if fast.IsSome && obj.ReferenceEquals(slow.Value, fast.Value) then
            slow <- head
            while not (obj.ReferenceEquals(slow.Value, fast.Value)) do
                slow <- slow.Value.Next
                fast <- fast.Value.Next
            answer <- slow
            searching <- false

    answer