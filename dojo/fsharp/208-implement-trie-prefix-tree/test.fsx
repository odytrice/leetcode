#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make () : Solution.Trie =
    if useReference then ReferenceSolution.ReferenceSolution() :> Solution.Trie
    else Solution.Trie()

test "word versus prefix" (fun () ->
    let trie = make ()
    trie.Insert "apple"
    equal true (trie.Search "apple")
    equal false (trie.Search "app")
    equal true (trie.StartsWith "app")
    trie.Insert "app"
    equal true (trie.Search "app"))

test "missing branch" (fun () ->
    let trie = make ()
    trie.Insert "cat"
    equal false (trie.Search "car")
    equal false (trie.StartsWith "z"))

test "duplicate insert" (fun () ->
    let trie = make ()
    trie.Insert "a"
    trie.Insert "a"
    equal true (trie.Search "a")
    equal false (trie.Search "aa"))

// Add your own cases here.

exit (finish ())
