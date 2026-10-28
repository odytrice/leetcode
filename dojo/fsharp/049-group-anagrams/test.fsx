#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let groupAnagrams =
    if useReference then ReferenceSolution.groupAnagrams else Solution.groupAnagrams

test "example" (fun () ->
    rowsSorted
        [ [ "eat"; "tea"; "ate" ]; [ "tan"; "nat" ]; [ "bat" ] ]
        (groupAnagrams [| "eat"; "tea"; "tan"; "ate"; "nat"; "bat" |]))
test "empty strings" (fun () -> rowsSorted [ [ ""; "" ] ] (groupAnagrams [| ""; "" |]))
test "letter counts" (fun () ->
    rowsSorted [ [ "ab"; "ba" ]; [ "aab" ] ] (groupAnagrams [| "ab"; "aab"; "ba" |]))

// Add your own cases here.

exit (finish ())
