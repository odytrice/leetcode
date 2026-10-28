#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let minCostConnectPoints =
    if useReference then ReferenceSolution.minCostConnectPoints else Solution.minCostConnectPoints

test "example" (fun () ->
    equal 20 (minCostConnectPoints [| [| 0; 0 |]; [| 2; 2 |]; [| 3; 10 |]; [| 5; 2 |]; [| 7; 0 |] |]))
test "single" (fun () -> equal 0 (minCostConnectPoints [| [| 4; -2 |] |]))
test "negative coordinates" (fun () ->
    equal 18 (minCostConnectPoints [| [| 3; 12 |]; [| -2; 5 |]; [| -4; 1 |] |]))
test "coordinate limits" (fun () ->
    equal 4_000_000 (minCostConnectPoints [| [| -1_000_000; -1_000_000 |]; [| 1_000_000; 1_000_000 |] |]))

// Add your own cases here.

exit (finish ())
