#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findMinArrowShots =
    if useReference then ReferenceSolution.findMinArrowShots else Solution.findMinArrowShots

test "example" (fun () ->
    equal 2 (findMinArrowShots [| [| 10; 16 |]; [| 2; 8 |]; [| 1; 6 |]; [| 7; 12 |] |]))
test "touching" (fun () -> equal 1 (findMinArrowShots [| [| 1; 2 |]; [| 2; 3 |] |]))
test "integer extremes" (fun () ->
    equal 2 (findMinArrowShots [| [| System.Int32.MinValue; -1 |]; [| 0; System.Int32.MaxValue |] |]))

// Add your own cases here.

exit (finish ())
