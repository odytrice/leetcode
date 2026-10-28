#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let subsets = if useReference then ReferenceSolution.subsets else Solution.subsets

test "two values" (fun () -> rowsSorted [ []; [ 1 ]; [ 2 ]; [ 1; 2 ] ] (subsets [| 1; 2 |]))
test "single" (fun () -> rowsSorted [ []; [ 0 ] ] (subsets [| 0 |]))
test "three values" (fun () ->
    rowsSorted
        [ []; [ -1 ]; [ 0 ]; [ 1 ]; [ -1; 0 ]; [ -1; 1 ]; [ 0; 1 ]; [ -1; 0; 1 ] ]
        (subsets [| -1; 0; 1 |]))

// Add your own cases here.

exit (finish ())
