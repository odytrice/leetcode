#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let minimumEffortPath =
    if useReference then ReferenceSolution.minimumEffortPath else Solution.minimumEffortPath

test "example" (fun () ->
    equal 2 (minimumEffortPath [| [| 1; 2; 2 |]; [| 3; 8; 2 |]; [| 5; 3; 5 |] |]))
test "single" (fun () -> equal 0 (minimumEffortPath [| [| 99 |] |]))
test "max not sum" (fun () -> equal 1 (minimumEffortPath [| [| 1; 2; 3; 4 |] |]))
test "detour" (fun () ->
    equal 0 (minimumEffortPath [| [| 1; 100; 1 |]; [| 1; 100; 1 |]; [| 1; 1; 1 |] |]))

// Add your own cases here.

exit (finish ())
