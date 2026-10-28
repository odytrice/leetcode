#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findRedundantConnection =
    if useReference then ReferenceSolution.findRedundantConnection else Solution.findRedundantConnection

test "triangle" (fun () -> sequence [ 2; 3 ] (findRedundantConnection [| [| 1; 2 |]; [| 1; 3 |]; [| 2; 3 |] |]))
test "cycle before final edge" (fun () ->
    sequence [ 1; 4 ] (findRedundantConnection [| [| 1; 2 |]; [| 2; 3 |]; [| 3; 4 |]; [| 1; 4 |]; [| 1; 5 |] |]))
test "input order tie break" (fun () ->
    sequence [ 1; 2 ] (findRedundantConnection [| [| 2; 3 |]; [| 1; 3 |]; [| 1; 2 |] |]))

// Add your own cases here.

exit (finish ())
