#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let numDecodings = if useReference then ReferenceSolution.numDecodings else Solution.numDecodings

test "example" (fun () -> equal 3 (numDecodings "226"))
test "leading zero" (fun () -> equal 0 (numDecodings "06"))
test "valid zeros" (fun () -> equal 1 (numDecodings "1010"))
test "invalid zero" (fun () -> equal 0 (numDecodings "100"))
test "pair too large" (fun () -> equal 1 (numDecodings "27"))

// Add your own cases here.

exit (finish ())
