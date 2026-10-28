#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make () : Solution.MinStack =
    if useReference then ReferenceSolution.ReferenceSolution() :> Solution.MinStack
    else Solution.MinStack()

test "example" (fun () ->
    let stack = make ()
    stack.Push -2
    stack.Push 0
    stack.Push -3
    equal -3 (stack.GetMin())
    stack.Pop()
    equal 0 (stack.Top())
    equal -2 (stack.GetMin()))

test "duplicate minimum" (fun () ->
    let stack = make ()
    stack.Push 1
    stack.Push 1
    stack.Pop()
    equal 1 (stack.GetMin()))

test "int limits" (fun () ->
    let stack = make ()
    stack.Push System.Int32.MinValue
    stack.Push System.Int32.MaxValue
    equal System.Int32.MinValue (stack.GetMin())
    equal System.Int32.MaxValue (stack.Top()))

// Add your own cases here.

exit (finish ())
