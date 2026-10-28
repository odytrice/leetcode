#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make () : Solution.StockSpanner =
    if useReference then ReferenceSolution.ReferenceSolution() :> Solution.StockSpanner
    else Solution.StockSpanner()

test "example" (fun () ->
    let spanner = make ()
    sequence
        [ 1; 1; 1; 2; 1; 4; 6 ]
        ([ 100; 80; 60; 70; 60; 75; 85 ] |> List.map spanner.Next))

test "equal prices" (fun () ->
    let spanner = make ()
    equal 1 (spanner.Next 5)
    equal 2 (spanner.Next 5)
    equal 3 (spanner.Next 5))

test "independent instances" (fun () ->
    (make ()).Next 1 |> ignore
    equal 1 ((make ()).Next 2))

// Add your own cases here.

exit (finish ())
