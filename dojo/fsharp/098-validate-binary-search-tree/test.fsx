#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let isValidBST = if useReference then ReferenceSolution.isValidBST else Solution.isValidBST

test "valid" (fun () -> equal true (isValidBST (TreeNode.From [| Some 2; Some 1; Some 3 |])))
test "ancestor violation" (fun () ->
    equal false (isValidBST (TreeNode.From [| Some 5; Some 1; Some 7; None; None; Some 4; Some 8 |])))
test "duplicate" (fun () -> equal false (isValidBST (TreeNode.From [| Some 2; Some 2; Some 3 |])))
test "integer limits" (fun () ->
    equal true (isValidBST (TreeNode.From [| Some 0; Some System.Int32.MinValue; Some System.Int32.MaxValue |])))

// Add your own cases here.

exit (finish ())
