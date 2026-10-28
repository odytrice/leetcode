module ReferenceSolution

open Models

// O(n) time. The last node of each level is the visible one.
let rightSideView (root: TreeNode option) : int list =
    let result = ResizeArray<int>()
    let mutable level = if root.IsSome then [ root.Value ] else []

    while not level.IsEmpty do
        result.Add level[level.Length - 1].Val
        level <- level |> List.collect (fun node -> [ node.Left; node.Right ] |> List.choose id)

    List.ofSeq result
