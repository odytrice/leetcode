#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make (matrix: int array array) : Solution.NumMatrix =
    if useReference then ReferenceSolution.ReferenceSolution(matrix) :> Solution.NumMatrix
    else Solution.NumMatrix(matrix)

test "whole rectangle" (fun () -> equal 10 ((make [| [| 1; 2 |]; [| 3; 4 |] |]).SumRegion 0 0 1 1))
test "interior" (fun () ->
    equal 8 ((make [| [| 1; 2; 3 |]; [| 4; 5; 6 |]; [| 7; 8; 9 |] |]).SumRegion 2 1 2 1))

test "negatives" (fun () ->
    let values = make [| [| -1; 2 |]; [| 3; -4 |] |]
    equal -1 (values.SumRegion 1 0 1 1)
    equal 0 (values.SumRegion 0 0 1 1))

// Add your own cases here.

exit (finish ())
