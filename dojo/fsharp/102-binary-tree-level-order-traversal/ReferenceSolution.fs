module ReferenceSolution

open Models

// O(n) time. Drains the queue one level at a time.
let levelOrder (root: TreeNode option) : int list list =
    let result = ResizeArray<int list>()
    let mutable level = if root.IsSome then [ root.Value ] else []

    while not level.IsEmpty do
        result.Add(level |> List.map (fun node -> node.Val))
        level <- level |> List.collect (fun node -> [ node.Left; node.Right ] |> List.choose id)

    List.ofSeq result
