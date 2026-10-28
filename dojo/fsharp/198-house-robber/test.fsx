#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let rob = if useReference then ReferenceSolution.rob else Solution.rob

test "example" (fun () -> equal 12 (rob [| 2; 7; 9; 3; 1 |]))
test "skip large neighbor" (fun () -> equal 4 (rob [| 2; 1; 1; 2 |]))
test "single" (fun () -> equal 5 (rob [| 5 |]))
test "zeros" (fun () -> equal 0 (rob [| 0; 0 |]))

// Add your own cases here.

exit (finish ())
