#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let search = if useReference then ReferenceSolution.search else Solution.search

test "rotated" (fun () -> equal 4 (search [| 4; 5; 6; 7; 0; 1; 2 |] 0))
test "absent" (fun () -> equal -1 (search [| 4; 5; 6; 7; 0; 1; 2 |] 3))
test "unrotated" (fun () -> equal 2 (search [| 1; 2; 3 |] 3))
test "single" (fun () -> equal 0 (search [| 1 |] 1))

// Add your own cases here.

exit (finish ())
