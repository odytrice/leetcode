#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let letterCombinations =
    if useReference then ReferenceSolution.letterCombinations else Solution.letterCombinations

test "example" (fun () ->
    set [ "ad"; "ae"; "af"; "bd"; "be"; "bf"; "cd"; "ce"; "cf" ] (letterCombinations "23"))
test "empty" (fun () -> equal 0 (letterCombinations "").Length)
test "four letter digit" (fun () -> set [ "p"; "q"; "r"; "s" ] (letterCombinations "7"))

// Add your own cases here.

exit (finish ())
