#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findMaxLength = if useReference then ReferenceSolution.findMaxLength else Solution.findMaxLength

test "example" (fun () -> equal 2 (findMaxLength [| 0; 1; 0 |]))
test "all one value" (fun () -> equal 0 (findMaxLength [| 1; 1; 1 |]))
test "earliest prefix" (fun () -> equal 6 (findMaxLength [| 0; 0; 1; 0; 1; 1; 0 |]))

// Add your own cases here.

exit (finish ())
