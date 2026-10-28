#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let kthSmallest = if useReference then ReferenceSolution.kthSmallest else Solution.kthSmallest

let tree (values: int option array) = (TreeNode.From values).Value

test "minimum" (fun () -> equal 1 (kthSmallest (tree [| Some 3; Some 1; Some 4; None; Some 2 |]) 1))
test "interior" (fun () -> equal 3 (kthSmallest (tree [| Some 5; Some 3; Some 6; Some 2; Some 4; None; None; Some 1 |]) 3))
test "maximum" (fun () -> equal 4 (kthSmallest (tree [| Some 3; Some 1; Some 4; None; Some 2 |]) 4))

// Add your own cases here.

exit (finish ())
