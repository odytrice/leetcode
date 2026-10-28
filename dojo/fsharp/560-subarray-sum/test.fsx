#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let subarraySum = if useReference then ReferenceSolution.subarraySum else Solution.subarraySum

test "example one" (fun () -> equal 2 (subarraySum [| 1; 1; 1 |] 2))
test "example two" (fun () -> equal 2 (subarraySum [| 1; 2; 3 |] 3))
test "example three" (fun () -> equal 3 (subarraySum [| 1; -1; 0 |] 0))
test "single match" (fun () -> equal 1 (subarraySum [| 3 |] 3))
test "no match" (fun () -> equal 0 (subarraySum [| 2; 4; 6 |] 5))

// Add your own cases here.

exit (finish ())
