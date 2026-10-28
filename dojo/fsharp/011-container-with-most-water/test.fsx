#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let maxArea = if useReference then ReferenceSolution.maxArea else Solution.maxArea

test "example" (fun () -> equal 49 (maxArea [| 1; 8; 6; 2; 5; 4; 8; 3; 7 |]))
test "two lines" (fun () -> equal 1 (maxArea [| 1; 1 |]))
test "zero heights" (fun () -> equal 0 (maxArea [| 0; 0; 0 |]))

// Add your own cases here.

exit (finish ())
