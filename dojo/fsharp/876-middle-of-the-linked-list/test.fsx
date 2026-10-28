#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let middleNode = if useReference then ReferenceSolution.middleNode else Solution.middleNode

test "odd" (fun () ->
    let head = ListNode.From [| 1; 2; 3; 4; 5 |]
    check (obj.ReferenceEquals(middleNode head, head.Next.Value.Next.Value)))

test "even" (fun () ->
    let head = ListNode.From [| 1; 2; 3; 4 |]
    check (obj.ReferenceEquals(middleNode head, head.Next.Value.Next.Value)))

test "single" (fun () ->
    let head = ListNode(1)
    check (obj.ReferenceEquals(middleNode head, head)))

// Add your own cases here.

exit (finish ())
