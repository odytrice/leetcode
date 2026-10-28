module ReferenceSolution

open Models

// O(max(m, n)) time. Adds column by column with a carry.
let addTwoNumbers (l1: ListNode) (l2: ListNode) : ListNode =
    let dummy = ListNode(0, None)
    let mutable tail = dummy
    let mutable first: ListNode option = Some l1
    let mutable second: ListNode option = Some l2
    let mutable carry = 0

    while first.IsSome || second.IsSome || carry <> 0 do
        let total =
            (if first.IsSome then first.Value.Val else 0)
            + (if second.IsSome then second.Value.Val else 0)
            + carry
        tail.Next <- Some(ListNode(total % 10, None))
        tail <- tail.Next.Value
        carry <- total / 10
        first <- (if first.IsSome then first.Value.Next else None)
        second <- (if second.IsSome then second.Value.Next else None)

    dummy.Next.Value
