module ReferenceSolution

open Models

// O(height + k) time. Stops the in-order walk at the kth value.
let kthSmallest (root: TreeNode) (k: int) : int =
    let stack = System.Collections.Generic.Stack<TreeNode>()
    let mutable node = Some root
    let mutable remaining = k
    let mutable answer = 0
    let mutable searching = true

    while searching && (node.IsSome || stack.Count > 0) do
        while node.IsSome do
            stack.Push node.Value
            node <- node.Value.Left
        let current = stack.Pop()
        remaining <- remaining - 1
        if remaining = 0 then
            answer <- current.Val
            searching <- false
        else
            node <- current.Right

    answer
