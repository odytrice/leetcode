#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findKthLargest = if useReference then ReferenceSolution.findKthLargest else Solution.findKthLargest

test "example" (fun () -> equal 5 (findKthLargest [| 3; 2; 1; 5; 6; 4 |] 2))
test "duplicates" (fun () -> equal 4 (findKthLargest [| 3; 2; 3; 1; 2; 4; 5; 5; 6 |] 4))
test "negative" (fun () -> equal -3 (findKthLargest [| -1; -3; -2 |] 3))

// Add your own cases here.

exit (finish ())
