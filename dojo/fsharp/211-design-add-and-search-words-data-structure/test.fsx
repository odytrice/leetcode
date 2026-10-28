#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make () : Solution.WordDictionary =
    if useReference then ReferenceSolution.ReferenceSolution() :> Solution.WordDictionary
    else Solution.WordDictionary()

test "wildcards" (fun () ->
    let dictionary = make ()
    for word in [ "bad"; "dad"; "mad" ] do
        dictionary.AddWord word
    equal true (dictionary.Search ".ad")
    equal true (dictionary.Search "b..")
    equal false (dictionary.Search "pad"))

test "exact length" (fun () ->
    let dictionary = make ()
    dictionary.AddWord "abc"
    equal false (dictionary.Search "..")
    equal false (dictionary.Search "abc.")
    equal false (dictionary.Search "ab"))

test "branch exploration" (fun () ->
    let dictionary = make ()
    dictionary.AddWord "cat"
    dictionary.AddWord "dog"
    equal true (dictionary.Search ".og")
    equal false (dictionary.Search ".ox"))

// Add your own cases here.

exit (finish ())
