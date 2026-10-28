#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let networkDelayTime =
    if useReference then ReferenceSolution.networkDelayTime else Solution.networkDelayTime

test "example" (fun () ->
    equal 2 (networkDelayTime [| [| 2; 1; 1 |]; [| 2; 3; 1 |]; [| 3; 4; 1 |] |] 4 2))
test "directed unreachable" (fun () -> equal -1 (networkDelayTime [| [| 1; 2; 1 |] |] 2 2))
test "improved route" (fun () ->
    equal 2 (networkDelayTime [| [| 1; 2; 10 |]; [| 1; 3; 1 |]; [| 3; 2; 1 |] |] 3 1))
test "zero weight" (fun () -> equal 0 (networkDelayTime [| [| 1; 2; 0 |] |] 2 1))

// Add your own cases here.

exit (finish ())
