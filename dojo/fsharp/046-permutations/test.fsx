#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let permute = if useReference then ReferenceSolution.permute else Solution.permute

test "two" (fun () -> rows [ [ 1; 2 ]; [ 2; 1 ] ] (permute [| 1; 2 |]))
test "single" (fun () -> rows [ [ 0 ] ] (permute [| 0 |]))
test "three" (fun () ->
    rows
        [ [ 1; 2; 3 ]; [ 1; 3; 2 ]; [ 2; 1; 3 ]; [ 2; 3; 1 ]; [ 3; 1; 2 ]; [ 3; 2; 1 ] ]
        (permute [| 1; 2; 3 |]))

// Add your own cases here.

exit (finish ())
