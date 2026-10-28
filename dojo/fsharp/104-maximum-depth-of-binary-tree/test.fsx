#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let maxDepth = if useReference then ReferenceSolution.maxDepth else Solution.maxDepth

test "example" (fun () -> equal 3 (maxDepth (TreeNode.From [| Some 3; Some 9; Some 20; None; None; Some 15; Some 7 |])))
test "empty" (fun () -> equal 0 (maxDepth None))
test "skewed" (fun () -> equal 3 (maxDepth (TreeNode.From [| Some 1; None; Some 2; None; Some 3 |])))

// Add your own cases here.

exit (finish ())
