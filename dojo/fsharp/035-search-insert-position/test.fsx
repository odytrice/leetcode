#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let searchInsert = if useReference then ReferenceSolution.searchInsert else Solution.searchInsert

test "found" (fun () -> equal 2 (searchInsert [| 1; 3; 5; 6 |] 5))
test "between" (fun () -> equal 1 (searchInsert [| 1; 3; 5; 6 |] 2))
test "after" (fun () -> equal 4 (searchInsert [| 1; 3; 5; 6 |] 7))
test "before" (fun () -> equal 0 (searchInsert [| 1 |] 0))

// Add your own cases here.

exit (finish ())
