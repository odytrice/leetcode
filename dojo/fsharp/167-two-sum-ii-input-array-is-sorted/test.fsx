#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let twoSum = if useReference then ReferenceSolution.twoSum else Solution.twoSum

test "example" (fun () -> sequence [ 1; 2 ] (twoSum [| 2; 7; 11; 15 |] 9))
test "negative" (fun () -> sequence [ 1; 3 ] (twoSum [| -3; 0; 4 |] 1))
test "duplicates" (fun () -> sequence [ 1; 2 ] (twoSum [| 2; 2 |] 4))

// Add your own cases here.

exit (finish ())
