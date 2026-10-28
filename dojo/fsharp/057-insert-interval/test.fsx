#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let insert = if useReference then ReferenceSolution.insert else Solution.insert

test "example" (fun () ->
    equal [ [ 1; 5 ]; [ 6; 9 ] ] (insert [| [| 1; 3 |]; [| 6; 9 |] |] [| 2; 5 |]))
test "bridge" (fun () ->
    equal [ [ 1; 2 ]; [ 3; 10 ]; [ 12; 16 ] ]
        (insert [| [| 1; 2 |]; [| 3; 5 |]; [| 6; 7 |]; [| 8; 10 |]; [| 12; 16 |] |] [| 4; 8 |]))
test "empty" (fun () -> equal [ [ 5; 7 ] ] (insert [||] [| 5; 7 |]))

// Add your own cases here.

exit (finish ())
