#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let lastStoneWeight = if useReference then ReferenceSolution.lastStoneWeight else Solution.lastStoneWeight

test "example" (fun () -> equal 1 (lastStoneWeight [| 2; 7; 4; 1; 8; 1 |]))
test "equal pair" (fun () -> equal 0 (lastStoneWeight [| 3; 3 |]))
test "single" (fun () -> equal 7 (lastStoneWeight [| 7 |]))

// Add your own cases here.

exit (finish ())
