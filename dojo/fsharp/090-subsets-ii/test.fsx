#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let subsetsWithDup = if useReference then ReferenceSolution.subsetsWithDup else Solution.subsetsWithDup

test "example" (fun () ->
    rowsSorted [ []; [ 1 ]; [ 2 ]; [ 1; 2 ]; [ 2; 2 ]; [ 1; 2; 2 ] ] (subsetsWithDup [| 1; 2; 2 |]))
test "all same" (fun () -> rowsSorted [ []; [ 0 ]; [ 0; 0 ] ] (subsetsWithDup [| 0; 0 |]))
test "unsorted" (fun () -> rowsSorted [ []; [ -1 ]; [ 2 ]; [ -1; 2 ] ] (subsetsWithDup [| 2; -1 |]))

// Add your own cases here.

exit (finish ())
