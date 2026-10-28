#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let kClosest = if useReference then ReferenceSolution.kClosest else Solution.kClosest

let asRows (points: int array array) = points |> Array.map Array.toList |> Array.toList

test "example" (fun () -> rows [ [ -2; 2 ] ] (asRows (kClosest [| [| 1; 3 |]; [| -2; 2 |] |] 1)))
test "all points" (fun () -> rows [ [ 1; 2 ]; [ 3; 4 ] ] (asRows (kClosest [| [| 1; 2 |]; [| 3; 4 |] |] 2)))
test "duplicates" (fun () ->
    rows [ [ 0; 0 ]; [ 0; 0 ] ] (asRows (kClosest [| [| 0; 0 |]; [| 0; 0 |]; [| 1; 1 |] |] 2)))

// Add your own cases here.

exit (finish ())