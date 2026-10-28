#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let orangesRotting = if useReference then ReferenceSolution.orangesRotting else Solution.orangesRotting

test "example" (fun () -> equal 4 (orangesRotting [| [| 2; 1; 1 |]; [| 1; 1; 0 |]; [| 0; 1; 1 |] |]))
test "unreachable" (fun () -> equal -1 (orangesRotting [| [| 2; 1; 1 |]; [| 0; 1; 1 |]; [| 1; 0; 1 |] |]))
test "no fresh" (fun () -> equal 0 (orangesRotting [| [| 0; 2 |] |]))
test "multiple sources" (fun () -> equal 1 (orangesRotting [| [| 2; 1; 2 |] |]))

// Add your own cases here.

exit (finish ())
