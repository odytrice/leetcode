module ReferenceSolution

open Models

// O(n) time. An in-order traversal of a BST is strictly increasing.
let isValidBST (root: TreeNode option) : bool =
    let stack = System.Collections.Generic.Stack<TreeNode>()
    let mutable previous = System.Int64.MinValue
    let mutable node = root
    let mutable valid = true

    while valid && (node.IsSome || stack.Count > 0) do
        while node.IsSome do
            stack.Push node.Value
            node <- node.Value.Left
        let current = stack.Pop()
        if int64 current.Val <= previous then
            valid <- false
        previous <- int64 current.Val
        node <- current.Right

    valid
