#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let pacificAtlantic = if useReference then ReferenceSolution.pacificAtlantic else Solution.pacificAtlantic

test "small slope" (fun () ->
    rows [ [ 0; 1 ]; [ 1; 0 ]; [ 1; 1 ] ] (pacificAtlantic [| [| 1; 2 |]; [| 4; 3 |] |]))
test "single cell" (fun () -> rows [ [ 0; 0 ] ] (pacificAtlantic [| [| 7 |] |]))
test "plateau" (fun () ->
    rows [ [ 0; 0 ]; [ 0; 1 ]; [ 1; 0 ]; [ 1; 1 ] ] (pacificAtlantic [| [| 1; 1 |]; [| 1; 1 |] |]))

// Add your own cases here.

exit (finish ())
