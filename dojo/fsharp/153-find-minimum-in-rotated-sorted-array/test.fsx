#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findMin = if useReference then ReferenceSolution.findMin else Solution.findMin

test "rotated" (fun () -> equal 1 (findMin [| 3; 4; 5; 1; 2 |]))
test "unrotated" (fun () -> equal 1 (findMin [| 1; 2; 3 |]))
test "single" (fun () -> equal -5 (findMin [| -5 |]))

// Add your own cases here.

exit (finish ())
