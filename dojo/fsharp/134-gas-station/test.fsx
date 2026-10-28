#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let canCompleteCircuit =
    if useReference then ReferenceSolution.canCompleteCircuit else Solution.canCompleteCircuit

test "example" (fun () -> equal 3 (canCompleteCircuit [| 1; 2; 3; 4; 5 |] [| 3; 4; 5; 1; 2 |]))
test "impossible" (fun () -> equal -1 (canCompleteCircuit [| 2; 3; 4 |] [| 3; 4; 3 |]))
test "single" (fun () -> equal 0 (canCompleteCircuit [| 5 |] [| 5 |]))

// Add your own cases here.

exit (finish ())
