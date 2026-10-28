#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findMinHeightTrees = if useReference then ReferenceSolution.findMinHeightTrees else Solution.findMinHeightTrees

test "star" (fun () -> set [ 1 ] (findMinHeightTrees 4 [| [| 1; 0 |]; [| 1; 2 |]; [| 1; 3 |] |]))
test "two centers" (fun () -> set [ 1; 2 ] (findMinHeightTrees 4 [| [| 0; 1 |]; [| 1; 2 |]; [| 2; 3 |] |]))
test "single" (fun () -> set [ 0 ] (findMinHeightTrees 1 [||]))

// Add your own cases here.

exit (finish ())
