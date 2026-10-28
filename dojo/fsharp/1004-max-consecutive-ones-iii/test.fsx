#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let longestOnes = if useReference then ReferenceSolution.longestOnes else Solution.longestOnes

test "example" (fun () -> equal 6 (longestOnes [| 1; 1; 1; 0; 0; 0; 1; 1; 1; 1; 0 |] 2))
test "no flips" (fun () -> equal 2 (longestOnes [| 1; 1; 0; 1 |] 0))
test "all zeros" (fun () -> equal 2 (longestOnes [| 0; 0; 0 |] 2))

// Add your own cases here.

exit (finish ())
