#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let eraseOverlapIntervals =
    if useReference then ReferenceSolution.eraseOverlapIntervals else Solution.eraseOverlapIntervals

test "example" (fun () -> equal 1 (eraseOverlapIntervals [| [| 1; 2 |]; [| 2; 3 |]; [| 3; 4 |]; [| 1; 3 |] |]))
test "duplicates" (fun () -> equal 2 (eraseOverlapIntervals [| [| 1; 2 |]; [| 1; 2 |]; [| 1; 2 |] |]))
test "touching" (fun () -> equal 0 (eraseOverlapIntervals [| [| 1; 2 |]; [| 2; 3 |] |]))

// Add your own cases here.

exit (finish ())
