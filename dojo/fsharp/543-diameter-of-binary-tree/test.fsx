#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let diameterOfBinaryTree =
    if useReference then ReferenceSolution.diameterOfBinaryTree else Solution.diameterOfBinaryTree

test "example" (fun () ->
    equal 3 (diameterOfBinaryTree (TreeNode.From [| Some 1; Some 2; Some 3; Some 4; Some 5 |])))
test "single" (fun () -> equal 0 (diameterOfBinaryTree (Some(TreeNode(1)))))
test "below root" (fun () ->
    equal 4 (diameterOfBinaryTree (TreeNode.From [| Some 1; Some 2; None; Some 3; Some 4; Some 5; None; None; Some 6 |])))

// Add your own cases here.

exit (finish ())
