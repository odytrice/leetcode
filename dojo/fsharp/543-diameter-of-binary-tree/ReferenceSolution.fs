module ReferenceSolution

open Models

// O(n) time. Height of each child, summed at every node, is the path through it.
let diameterOfBinaryTree (root: TreeNode option) : int =
    let mutable best = 0

    let rec height (node: TreeNode option) : int =
        match node with
        | None -> 0
        | Some value ->
            let left = height value.Left
            let right = height value.Right
            best <- max best (left + right)
            1 + max left right

    height root |> ignore
    best
