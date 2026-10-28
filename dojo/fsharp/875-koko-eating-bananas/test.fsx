#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let minEatingSpeed =
    if useReference then ReferenceSolution.minEatingSpeed else Solution.minEatingSpeed

test "example" (fun () -> equal 4 (minEatingSpeed [| 3; 6; 7; 11 |] 8))
test "one hour per pile" (fun () -> equal 30 (minEatingSpeed [| 30; 11; 23; 4; 20 |] 5))
test "large total hours" (fun () ->
    equal 4 (minEatingSpeed [| 1_000_000_000; 1_000_000_000; 1_000_000_000 |] 1_000_000_000))

// Add your own cases here.

exit (finish ())
