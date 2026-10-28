#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let productExceptSelf =
    if useReference then ReferenceSolution.productExceptSelf else Solution.productExceptSelf

test "example" (fun () -> sequence [ 24; 12; 8; 6 ] (productExceptSelf [| 1; 2; 3; 4 |]))
test "one zero" (fun () -> sequence [ 0; 0; 9; 0; 0 ] (productExceptSelf [| -1; 1; 0; -3; 3 |]))
test "two zeros" (fun () -> sequence [ 0; 0; 0 ] (productExceptSelf [| 0; 2; 0 |]))

// Add your own cases here.

exit (finish ())
