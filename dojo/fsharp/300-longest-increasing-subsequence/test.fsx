#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let lengthOfLIS = if useReference then ReferenceSolution.lengthOfLIS else Solution.lengthOfLIS

test "example" (fun () -> equal 4 (lengthOfLIS [| 10; 9; 2; 5; 3; 7; 101; 18 |]))
test "equal" (fun () -> equal 1 (lengthOfLIS [| 7; 7; 7 |]))
test "decreasing" (fun () -> equal 1 (lengthOfLIS [| 3; 2; 1 |]))
test "replace tails" (fun () -> equal 4 (lengthOfLIS [| 0; 1; 0; 3; 2; 3 |]))

// Add your own cases here.

exit (finish ())
