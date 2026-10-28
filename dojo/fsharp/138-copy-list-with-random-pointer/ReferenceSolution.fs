module ReferenceSolution

open Solution

// O(n) time and space. Copies every node first, then wires the pointers.
let copyRandomList (head: RandomNode option) : RandomNode option =
    let copies = System.Collections.Generic.Dictionary<RandomNode, RandomNode>(HashIdentity.Reference)
    let mutable node = head
    while node.IsSome do
        copies[node.Value] <- RandomNode(node.Value.Val)
        node <- node.Value.Next

    node <- head
    while node.IsSome do
        let copy = copies[node.Value]
        copy.Next <- (if node.Value.Next.IsSome then Some copies[node.Value.Next.Value] else None)
        copy.Random <- (if node.Value.Random.IsSome then Some copies[node.Value.Random.Value] else None)
        node <- node.Value.Next

    if head.IsSome then Some copies[head.Value] else None
