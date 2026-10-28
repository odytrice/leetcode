#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make (nums: int array) : Solution.NumArray =
    if useReference then ReferenceSolution.ReferenceSolution(nums) :> Solution.NumArray
    else Solution.NumArray(nums)

test "queries" (fun () ->
    let values = make [| -2; 0; 3; -5; 2; -1 |]
    equal 1 (values.SumRange 0 2)
    equal -1 (values.SumRange 2 5)
    equal -3 (values.SumRange 0 5))

test "single" (fun () -> equal -5 ((make [| -5 |]).SumRange 0 0))

test "repeated query" (fun () ->
    let values = make [| 1; 2 |]
    equal 3 (values.SumRange 0 1)
    equal 3 (values.SumRange 0 1))

// Add your own cases here.

exit (finish ())
