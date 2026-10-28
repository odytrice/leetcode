#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let isValid = if useReference then ReferenceSolution.isValid else Solution.isValid

test "nested" (fun () -> equal true (isValid "([]){}"))
test "crossed" (fun () -> equal false (isValid "([)]"))
test "unclosed" (fun () -> equal false (isValid "("))
test "unopened" (fun () -> equal false (isValid ")"))

// Add your own cases here.

exit (finish ())
