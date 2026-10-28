#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let make () : Solution.RandomizedSet =
    if useReference then ReferenceSolution.ReferenceSolution() :> Solution.RandomizedSet
    else Solution.RandomizedSet()

test "insert and remove" (fun () ->
    let values = make ()
    equal true (values.Insert 1)
    equal false (values.Insert 1)
    equal false (values.Remove 2)
    equal true (values.Remove 1)
    equal false (values.Remove 1))

test "swap removal" (fun () ->
    let values = make ()
    values.Insert 10 |> ignore
    values.Insert 20 |> ignore
    values.Insert 30 |> ignore
    values.Remove 20 |> ignore
    equal true (values.Remove 30)
    equal 10 (values.GetRandom()))

test "random membership" (fun () ->
    let values = make ()
    values.Insert -1 |> ignore
    values.Insert 2 |> ignore
    values.Insert 3 |> ignore
    values.Remove 2 |> ignore
    for _ in 1..200 do
        checkMessage (List.contains (values.GetRandom()) [ -1; 3 ]) "unexpected value")

test "reinsert" (fun () ->
    let values = make ()
    values.Insert 7 |> ignore
    values.Remove 7 |> ignore
    equal true (values.Insert 7)
    equal 7 (values.GetRandom()))

// Add your own cases here.

exit (finish ())
