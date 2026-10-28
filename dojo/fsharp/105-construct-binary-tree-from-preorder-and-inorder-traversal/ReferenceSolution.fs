module ReferenceSolution

open Models

// O(n) time. Iterative: attaches each preorder node, popping finished left chains.
let buildTree (preorder: int array) (inorder: int array) : TreeNode =
    let root = TreeNode(preorder[0])
    let stack = System.Collections.Generic.Stack<TreeNode>()
    stack.Push root
    let mutable index = 0

    for position in 1 .. preorder.Length - 1 do
        let mutable parent = stack.Peek()
        let node = TreeNode(preorder[position])
        if parent.Val <> inorder[index] then
            parent.Left <- Some node
        else
            let mutable popping = true
            while popping && stack.Count > 0 && stack.Peek().Val = inorder[index] do
                parent <- stack.Pop()
                index <- index + 1
            parent.Right <- Some node
        stack.Push node

    root
