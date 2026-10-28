#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let shortestPathBinaryMatrix =
    if useReference then ReferenceSolution.shortestPathBinaryMatrix else Solution.shortestPathBinaryMatrix

test "diagonal" (fun () -> equal 2 (shortestPathBinaryMatrix [| [| 0; 1 |]; [| 1; 0 |] |]))
test "single" (fun () -> equal 1 (shortestPathBinaryMatrix [| [| 0 |] |]))
test "blocked start" (fun () -> equal -1 (shortestPathBinaryMatrix [| [| 1; 0 |]; [| 0; 0 |] |]))
test "disconnected" (fun () ->
    equal -1 (shortestPathBinaryMatrix [| [| 0; 0; 0 |]; [| 1; 1; 1 |]; [| 0; 0; 0 |] |]))

// Add your own cases here.

exit (finish ())
