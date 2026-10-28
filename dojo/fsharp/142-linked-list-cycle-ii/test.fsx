#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let detectCycle = if useReference then ReferenceSolution.detectCycle else Solution.detectCycle

test "cycle entry" (fun () ->
    let head = ListNode.From [| 3; 2; 0; -4 |]
    let entry = head.Next.Value
    head.Next.Value.Next.Value.Next.Value.Next <- Some entry
    check (obj.ReferenceEquals((detectCycle (Some head)).Value, entry))
    check (obj.ReferenceEquals(head.Next.Value, entry)))

test "no cycle" (fun () -> check (detectCycle (Some(ListNode.From [| 1; 2 |]))).IsNone)

test "self cycle" (fun () ->
    let head = ListNode(1)
    head.Next <- Some head
    check (obj.ReferenceEquals((detectCycle (Some head)).Value, head)))

test "empty" (fun () -> check (detectCycle None).IsNone)

// Add your own cases here.

exit (finish ())
