#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let threeSumClosest =
    if useReference then ReferenceSolution.threeSumClosest else Solution.threeSumClosest

test "example" (fun () -> equal 2 (threeSumClosest [| -1; 2; 1; -4 |] 1))
test "zeros" (fun () -> equal 0 (threeSumClosest [| 0; 0; 0 |] 1))
test "exact" (fun () -> equal 3 (threeSumClosest [| 1; 1; 1; 0 |] 3))

// Add your own cases here.

exit (finish ())
