#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make () : Solution.MedianFinder =
    if useReference then ReferenceSolution.ReferenceSolution() :> Solution.MedianFinder
    else Solution.MedianFinder()

test "example" (fun () ->
    let finder = make ()
    finder.AddNum 1
    finder.AddNum 2
    near 1.5 (finder.FindMedian())
    finder.AddNum 3
    near 2.0 (finder.FindMedian()))

test "negative values" (fun () ->
    let finder = make ()
    finder.AddNum -1
    finder.AddNum -2
    near -1.5 (finder.FindMedian())
    finder.AddNum -3
    near -2.0 (finder.FindMedian()))

test "duplicates" (fun () ->
    let finder = make ()
    for _ in 1..8 do
        finder.AddNum 7
        near 7.0 (finder.FindMedian()))

// Add your own cases here.

exit (finish ())
