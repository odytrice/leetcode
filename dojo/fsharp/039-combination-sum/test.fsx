#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let combinationSum = if useReference then ReferenceSolution.combinationSum else Solution.combinationSum

test "example" (fun () ->
    rowsSorted [ [ 2; 2; 3 ]; [ 7 ] ] (combinationSum [| 2; 3; 6; 7 |] 7))
test "multiple combinations" (fun () ->
    rowsSorted [ [ 2; 2; 2; 2 ]; [ 2; 3; 3 ]; [ 3; 5 ] ] (combinationSum [| 2; 3; 5 |] 8))
test "impossible" (fun () -> equal [] (combinationSum [| 2 |] 1))

// Add your own cases here.

exit (finish ())
