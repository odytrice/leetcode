#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let checkSubarraySum =
    if useReference then ReferenceSolution.checkSubarraySum else Solution.checkSubarraySum

test "example" (fun () -> equal true (checkSubarraySum [| 23; 2; 4; 6; 7 |] 6))
test "absent" (fun () -> equal false (checkSubarraySum [| 23; 2; 6; 4; 7 |] 13))
test "too short" (fun () -> equal false (checkSubarraySum [| 6 |] 6))
test "zero sum" (fun () -> equal true (checkSubarraySum [| 0; 0 |] 7))

// Add your own cases here.

exit (finish ())
