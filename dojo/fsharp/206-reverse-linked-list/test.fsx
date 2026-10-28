#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let reverseList = if useReference then ReferenceSolution.reverseList else Solution.reverseList

test "example" (fun () -> sequence [ 3; 2; 1 ] (ListNode.Values(reverseList (Some(ListNode.From [| 1; 2; 3 |])))))
test "empty" (fun () -> check (reverseList None).IsNone)

test "single" (fun () ->
    let node = ListNode(7)
    check (obj.ReferenceEquals((reverseList (Some node)).Value, node)))

// Add your own cases here.

exit (finish ())
