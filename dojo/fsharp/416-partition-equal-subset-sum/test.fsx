#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let canPartition = if useReference then ReferenceSolution.canPartition else Solution.canPartition

test "example" (fun () -> equal true (canPartition [| 1; 5; 11; 5 |]))
test "odd sum" (fun () -> equal false (canPartition [| 1; 2; 3; 5 |]))
test "no element reuse" (fun () -> equal false (canPartition [| 1; 2; 5 |]))
test "equal pair" (fun () -> equal true (canPartition [| 100; 100 |]))

// Add your own cases here.

exit (finish ())
