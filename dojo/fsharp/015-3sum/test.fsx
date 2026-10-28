#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let threeSum = if useReference then ReferenceSolution.threeSum else Solution.threeSum

test "example" (fun () ->
    rowsSorted [ [ -1; -1; 2 ]; [ -1; 0; 1 ] ] (threeSum [| -1; 0; 1; 2; -1; -4 |]))
test "duplicates" (fun () -> rowsSorted [ [ 0; 0; 0 ] ] (threeSum [| 0; 0; 0; 0 |]))
test "no answer" (fun () -> equal 0 (List.length (threeSum [| 1; 2; 3 |])))

// Add your own cases here.

exit (finish ())
