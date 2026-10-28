module ReferenceSolution

open Models

// O(n) time. Records every parent, then walks up from both nodes.
let lowestCommonAncestor (root: TreeNode) (p: TreeNode) (q: TreeNode) : TreeNode =
    let parents = System.Collections.Generic.Dictionary<TreeNode, TreeNode option>(HashIdentity.Reference)
    parents[root] <- None
    let stack = System.Collections.Generic.Stack<TreeNode>()
    stack.Push root

    while stack.Count > 0 do
        let node = stack.Pop()
        for child in [ node.Left; node.Right ] |> List.choose id do
            parents[child] <- Some node
            stack.Push child

    let ancestors = System.Collections.Generic.HashSet<TreeNode>(HashIdentity.Reference)
    let mutable current: TreeNode option = Some p
    while current.IsSome do
        ancestors.Add current.Value |> ignore
        current <- parents[current.Value]

    let mutable answer = q
    while not (ancestors.Contains answer) do
        answer <- parents[answer].Value

    answer