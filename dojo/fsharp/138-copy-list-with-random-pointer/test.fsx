#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let copyRandomList =
    if useReference then ReferenceSolution.copyRandomList else Solution.copyRandomList

test "cross pointers and duplicate values" (fun () ->
    let first = Solution.RandomNode(7)
    let second = Solution.RandomNode(7)
    first.Next <- Some second
    first.Random <- Some second
    second.Random <- Some first

    let copy = (copyRandomList (Some first)).Value
    check (not (obj.ReferenceEquals(copy, first)) && not (obj.ReferenceEquals(copy.Next.Value, second)))
    equal 7 copy.Val
    equal 7 copy.Next.Value.Val
    check (obj.ReferenceEquals(copy.Random.Value, copy.Next.Value))
    check (obj.ReferenceEquals(copy.Next.Value.Random.Value, copy))
    check (obj.ReferenceEquals(first.Next.Value, second) && obj.ReferenceEquals(second.Random.Value, first)))

test "self random" (fun () ->
    let node = Solution.RandomNode(1)
    node.Random <- Some node
    let copy = (copyRandomList (Some node)).Value
    check (not (obj.ReferenceEquals(copy, node)))
    check (obj.ReferenceEquals(copy.Random.Value, copy))
    check copy.Next.IsNone)

test "empty" (fun () -> check (copyRandomList None).IsNone)

// Add your own cases here.

exit (finish ())
