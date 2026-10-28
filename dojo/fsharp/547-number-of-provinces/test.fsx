#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findCircleNum = if useReference then ReferenceSolution.findCircleNum else Solution.findCircleNum

test "example" (fun () -> equal 2 (findCircleNum [| [| 1; 1; 0 |]; [| 1; 1; 0 |]; [| 0; 0; 1 |] |]))
test "isolated" (fun () -> equal 3 (findCircleNum [| [| 1; 0; 0 |]; [| 0; 1; 0 |]; [| 0; 0; 1 |] |]))
test "transitive" (fun () -> equal 1 (findCircleNum [| [| 1; 1; 0 |]; [| 1; 1; 1 |]; [| 0; 1; 1 |] |]))

// Add your own cases here.

exit (finish ())
