#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let canJump = if useReference then ReferenceSolution.canJump else Solution.canJump

test "reachable" (fun () -> equal true (canJump [| 2; 3; 1; 1; 4 |]))
test "blocked" (fun () -> equal false (canJump [| 3; 2; 1; 0; 4 |]))
test "already there" (fun () -> equal true (canJump [| 0 |]))
test "jump over zero" (fun () -> equal true (canJump [| 2; 0; 0 |]))

// Add your own cases here.

exit (finish ())
