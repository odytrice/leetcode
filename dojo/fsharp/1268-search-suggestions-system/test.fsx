#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let suggestedProducts =
    if useReference then ReferenceSolution.suggestedProducts else Solution.suggestedProducts

test "lexicographic top three" (fun () ->
    equal
        [ [ "baggage"; "bags"; "banner" ]; [ "baggage"; "bags"; "banner" ] ]
        (suggestedProducts [| "bags"; "baggage"; "banner"; "box"; "cloth" |] "ba"))
test "missing suffix" (fun () -> equal [ [ "a" ]; []; [] ] (suggestedProducts [| "a" |] "abc"))
test "fewer than three" (fun () ->
    equal [ [ "car"; "cat" ]; [ "car"; "cat" ]; [ "cat" ] ] (suggestedProducts [| "cat"; "car" |] "cat"))

// Add your own cases here.

exit (finish ())
