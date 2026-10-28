#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let levelOrder = if useReference then ReferenceSolution.levelOrder else Solution.levelOrder

test "example" (fun () ->
    equal [ [ 3 ]; [ 9; 20 ]; [ 15; 7 ] ] (levelOrder (TreeNode.From [| Some 3; Some 9; Some 20; None; None; Some 15; Some 7 |])))
test "empty" (fun () -> equal [] (levelOrder None))
test "single" (fun () -> equal [ [ 1 ] ] (levelOrder (Some(TreeNode(1)))))

// Add your own cases here.

exit (finish ())
