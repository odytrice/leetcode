#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let lowestCommonAncestor =
    if useReference then ReferenceSolution.lowestCommonAncestor else Solution.lowestCommonAncestor

test "different subtrees" (fun () ->
    let root = (TreeNode.From [| Some 3; Some 5; Some 1 |]).Value
    check (obj.ReferenceEquals(lowestCommonAncestor root root.Left.Value root.Right.Value, root)))

test "ancestor is target" (fun () ->
    let root = (TreeNode.From [| Some 3; Some 5; Some 1; Some 6; Some 2 |]).Value
    let child = root.Left.Value
    check (obj.ReferenceEquals(lowestCommonAncestor root child child.Right.Value, child)))

test "two nodes" (fun () ->
    let root = (TreeNode.From [| Some 1; Some 2 |]).Value
    check (obj.ReferenceEquals(lowestCommonAncestor root root root.Left.Value, root)))

// Add your own cases here.

exit (finish ())
