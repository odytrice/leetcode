#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let twoSum = if useReference then ReferenceSolution.twoSum else Solution.twoSum

test "example" (fun () -> set [ 0; 1 ] (twoSum [| 2; 7; 11; 15 |] 9))
test "duplicate values" (fun () -> set [ 0; 1 ] (twoSum [| 3; 3 |] 6))
test "negative values" (fun () -> set [ 1; 2 ] (twoSum [| 4; -2; -3 |] -5))

// Add your own cases here.

exit (finish ())
