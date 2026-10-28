#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let wordBreak = if useReference then ReferenceSolution.wordBreak else Solution.wordBreak

test "example" (fun () -> equal true (wordBreak "leetcode" [ "leet"; "code" ]))
test "reuse" (fun () -> equal true (wordBreak "applepenapple" [ "apple"; "pen" ]))
test "impossible suffix" (fun () ->
    equal false (wordBreak "catsandog" [ "cats"; "dog"; "sand"; "and"; "cat" ]))
test "non greedy split" (fun () -> equal true (wordBreak "aaaaaaa" [ "aaaa"; "aaa" ]))

// Add your own cases here.

exit (finish ())
