#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let merge = if useReference then ReferenceSolution.merge else Solution.merge

test "example" (fun () -> equal [ [ 1; 6 ]; [ 8; 10 ]; [ 15; 18 ] ]
                               (merge [| [| 1; 3 |]; [| 2; 6 |]; [| 8; 10 |]; [| 15; 18 |] |]))
test "touching endpoints" (fun () -> equal [ [ 1; 5 ] ] (merge [| [| 1; 4 |]; [| 4; 5 |] |]))
test "unordered and contained" (fun () ->
    equal [ [ 1; 4 ]; [ 8; 10 ] ] (merge [| [| 8; 10 |]; [| 1; 4 |]; [| 2; 3 |] |]))
test "contained interval must not shrink end" (fun () ->
    equal [ [ 1; 12 ] ] (merge [| [| 1; 10 |]; [| 2; 3 |]; [| 9; 12 |] |]))
test "zero length intervals" (fun () ->
    equal [ [ 1; 1 ]; [ 3; 4 ] ] (merge [| [| 3; 3 |]; [| 1; 1 |]; [| 3; 4 |] |]))

// Add your own cases here.

exit (finish ())
