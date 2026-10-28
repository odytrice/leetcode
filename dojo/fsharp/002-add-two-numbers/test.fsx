#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let addTwoNumbers = if useReference then ReferenceSolution.addTwoNumbers else Solution.addTwoNumbers

test "example" (fun () ->
    sequence [ 7; 0; 8 ] (ListNode.Values(Some(addTwoNumbers (ListNode.From [| 2; 4; 3 |]) (ListNode.From [| 5; 6; 4 |])))))

test "carry chain" (fun () ->
    sequence [ 0; 0; 0; 1 ] (ListNode.Values(Some(addTwoNumbers (ListNode.From [| 9; 9; 9 |]) (ListNode(1))))))

test "zero" (fun () ->
    sequence [ 0 ] (ListNode.Values(Some(addTwoNumbers (ListNode(0)) (ListNode(0))))))

// Add your own cases here.

exit (finish ())
