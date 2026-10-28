#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let maxAreaOfIsland = if useReference then ReferenceSolution.maxAreaOfIsland else Solution.maxAreaOfIsland

test "example" (fun () -> equal 3 (maxAreaOfIsland [| [| 1; 1; 0 |]; [| 0; 1; 0 |]; [| 1; 0; 1 |] |]))
test "water" (fun () -> equal 0 (maxAreaOfIsland [| [| 0; 0 |] |]))
test "diagonal" (fun () -> equal 1 (maxAreaOfIsland [| [| 1; 0 |]; [| 0; 1 |] |]))

// Add your own cases here.

exit (finish ())
