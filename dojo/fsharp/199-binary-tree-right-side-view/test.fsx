#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let rightSideView = if useReference then ReferenceSolution.rightSideView else Solution.rightSideView

test "example" (fun () ->
    sequence [ 1; 3; 4 ] (rightSideView (TreeNode.From [| Some 1; Some 2; Some 3; None; Some 5; None; Some 4 |])))
test "left continues" (fun () ->
    sequence [ 1; 3; 4 ] (rightSideView (TreeNode.From [| Some 1; Some 2; Some 3; Some 4 |])))
test "empty" (fun () -> sequence [] (rightSideView None))

// Add your own cases here.

exit (finish ())
