#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let sortColors = if useReference then ReferenceSolution.sortColors else Solution.sortColors

let verify (values: int array) (expected: int array) =
    let copy = Array.copy values
    sortColors copy
    sequence expected copy

test "example" (fun () -> verify [| 2; 0; 2; 1; 1; 0 |] [| 0; 0; 1; 1; 2; 2 |])
test "reverse" (fun () -> verify [| 2; 1; 0 |] [| 0; 1; 2 |])
test "single" (fun () -> verify [| 2 |] [| 2 |])

// Add your own cases here.

exit (finish ())
