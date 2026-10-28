#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let coinChange = if useReference then ReferenceSolution.coinChange else Solution.coinChange

test "example" (fun () -> equal 3 (coinChange [| 1; 2; 5 |] 11))
test "impossible" (fun () -> equal -1 (coinChange [| 2 |] 3))
test "zero" (fun () -> equal 0 (coinChange [| 1 |] 0))
test "greedy fails" (fun () -> equal 2 (coinChange [| 1; 3; 4 |] 6))

// Add your own cases here.

exit (finish ())
