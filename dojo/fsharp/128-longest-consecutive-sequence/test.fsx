#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let longestConsecutive =
    if useReference then ReferenceSolution.longestConsecutive else Solution.longestConsecutive

test "example" (fun () -> equal 4 (longestConsecutive [| 100; 4; 200; 1; 3; 2 |]))
test "duplicates and negatives" (fun () -> equal 4 (longestConsecutive [| 0; -1; 1; 2; 2 |]))
test "empty" (fun () -> equal 0 (longestConsecutive [||]))

// Add your own cases here.

exit (finish ())
