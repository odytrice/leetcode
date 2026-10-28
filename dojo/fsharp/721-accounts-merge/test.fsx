#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let accountsMerge = if useReference then ReferenceSolution.accountsMerge else Solution.accountsMerge

test "transitive merge" (fun () ->
    set [ [ "John"; "a@x"; "b@x"; "c@x" ] ]
        (accountsMerge [ [ "John"; "a@x" ]; [ "John"; "b@x"; "c@x" ]; [ "John"; "a@x"; "b@x" ] ]))
test "same name distinct people" (fun () ->
    set [ [ "John"; "a@x" ]; [ "John"; "b@x" ] ]
        (accountsMerge [ [ "John"; "a@x" ]; [ "John"; "b@x" ] ]))
test "sorted and deduplicated" (fun () ->
    set [ [ "Mary"; "a@x"; "z@x" ] ] (accountsMerge [ [ "Mary"; "z@x"; "a@x"; "z@x" ] ]))

// Add your own cases here.

exit (finish ())
