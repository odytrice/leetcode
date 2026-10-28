module ReferenceSolution

open Models

// O(n) time. BFS counts one level per queue drain.
let maxDepth (root: TreeNode option) : int =
    let mutable depth = 0
    let mutable level = if root.IsSome then [ root.Value ] else []

    while not level.IsEmpty do
        depth <- depth + 1
        level <-
            level
            |> List.collect (fun node -> [ node.Left; node.Right ] |> List.choose id)

    depth
