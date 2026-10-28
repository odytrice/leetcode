#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let canFinish = if useReference then ReferenceSolution.canFinish else Solution.canFinish

test "possible" (fun () -> equal true (canFinish 2 [| [| 1; 0 |] |]))
test "cycle" (fun () -> equal false (canFinish 2 [| [| 1; 0 |]; [| 0; 1 |] |]))
test "disconnected cycle" (fun () -> equal false (canFinish 4 [| [| 1; 0 |]; [| 2; 3 |]; [| 3; 2 |] |]))
test "no edges" (fun () -> equal true (canFinish 3 [||]))

// Add your own cases here.

exit (finish ())
