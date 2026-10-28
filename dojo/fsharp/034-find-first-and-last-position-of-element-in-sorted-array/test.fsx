#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let searchRange = if useReference then ReferenceSolution.searchRange else Solution.searchRange

test "example" (fun () -> sequence [ 3; 4 ] (searchRange [| 5; 7; 7; 8; 8; 10 |] 8))
test "absent" (fun () -> sequence [ -1; -1 ] (searchRange [| 1; 3 |] 2))
test "empty" (fun () -> sequence [ -1; -1 ] (searchRange [||] 0))
test "all equal" (fun () -> sequence [ 0; 2 ] (searchRange [| 2; 2; 2 |] 2))

// Add your own cases here.

exit (finish ())
