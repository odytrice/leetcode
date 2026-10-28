#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let minSubArrayLen = if useReference then ReferenceSolution.minSubArrayLen else Solution.minSubArrayLen

test "example" (fun () -> equal 2 (minSubArrayLen 7 [| 2; 3; 1; 2; 4; 3 |]))
test "one element" (fun () -> equal 1 (minSubArrayLen 4 [| 1; 4; 4 |]))
test "unreachable" (fun () -> equal 0 (minSubArrayLen 11 [| 1; 1; 1; 1 |]))

// Add your own cases here.

exit (finish ())
