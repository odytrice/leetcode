#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let uniquePaths = if useReference then ReferenceSolution.uniquePaths else Solution.uniquePaths

test "example" (fun () -> equal 28 (uniquePaths 3 7))
test "one row" (fun () -> equal 1 (uniquePaths 1 100))
test "one column" (fun () -> equal 1 (uniquePaths 100 1))
test "square" (fun () -> equal 6 (uniquePaths 3 3))

// Add your own cases here.

exit (finish ())
