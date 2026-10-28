#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let removeNthFromEnd =
    if useReference then ReferenceSolution.removeNthFromEnd else Solution.removeNthFromEnd

test "example" (fun () ->
    sequence [ 1; 2; 3; 5 ] (ListNode.Values(removeNthFromEnd (ListNode.From [| 1; 2; 3; 4; 5 |]) 2)))

test "remove head" (fun () ->
    let head = ListNode.From [| 1; 2 |]
    check (obj.ReferenceEquals((removeNthFromEnd head 2).Value, head.Next.Value)))

test "remove only node" (fun () -> check (removeNthFromEnd (ListNode(1)) 1).IsNone)

// Add your own cases here.

exit (finish ())
