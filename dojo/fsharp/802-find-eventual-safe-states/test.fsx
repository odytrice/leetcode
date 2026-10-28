#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let eventualSafeNodes =
    if useReference then ReferenceSolution.eventualSafeNodes else Solution.eventualSafeNodes

test "example" (fun () ->
    sequence [ 2; 4; 5; 6 ] (eventualSafeNodes [| [| 1; 2 |]; [| 2; 3 |]; [| 5 |]; [| 0 |]; [| 5 |]; [||]; [||] |]))
test "self loop" (fun () -> sequence [ 1 ] (eventualSafeNodes [| [| 0 |]; [||] |]))
test "all terminal" (fun () -> sequence [ 0; 1 ] (eventualSafeNodes [| [||]; [||] |]))

// Add your own cases here.

exit (finish ())
