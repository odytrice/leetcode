#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let reorderList = if useReference then ReferenceSolution.reorderList else Solution.reorderList

let verify (values: int array) (expected: int list) =
    let head = ListNode.From values
    reorderList head
    sequence expected (ListNode.Values(Some head))

test "odd" (fun () -> verify [| 1; 2; 3; 4; 5 |] [ 1; 5; 2; 4; 3 ])
test "even" (fun () -> verify [| 1; 2; 3; 4 |] [ 1; 4; 2; 3 ])
test "single" (fun () -> verify [| 1 |] [ 1 ])

// Add your own cases here.

exit (finish ())
