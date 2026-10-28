#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let shipWithinDays =
    if useReference then ReferenceSolution.shipWithinDays else Solution.shipWithinDays

test "example" (fun () -> equal 15 (shipWithinDays [| 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 |] 5))
test "one day" (fun () -> equal 6 (shipWithinDays [| 1; 2; 3 |] 1))
test "one per day" (fun () -> equal 3 (shipWithinDays [| 1; 2; 3 |] 3))

// Add your own cases here.

exit (finish ())
