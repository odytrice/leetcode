#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let topKFrequent = if useReference then ReferenceSolution.topKFrequent else Solution.topKFrequent

test "example" (fun () -> set [ 1; 2 ] (topKFrequent [| 1; 1; 1; 2; 2; 3 |] 2))
test "single element" (fun () -> set [ 1 ] (topKFrequent [| 1 |] 1))
test "negative values" (fun () -> set [ -1; 4 ] (topKFrequent [| 4; 4; 4; -1; -1; 2 |] 2))

// Add your own cases here.

exit (finish ())
