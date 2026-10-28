#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let checkInclusion = if useReference then ReferenceSolution.checkInclusion else Solution.checkInclusion

test "present" (fun () -> equal true (checkInclusion "ab" "eidbaooo"))
test "absent" (fun () -> equal false (checkInclusion "ab" "eidboaoo"))
test "multiplicities" (fun () -> equal false (checkInclusion "aab" "abb"))
test "pattern longer" (fun () -> equal false (checkInclusion "abc" "ab"))

// Add your own cases here.

exit (finish ())
