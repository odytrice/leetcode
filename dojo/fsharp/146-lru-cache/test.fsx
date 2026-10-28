#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"

let make (capacity: int) : Solution.LRUCache =
    if useReference then ReferenceSolution.ReferenceSolution(capacity) :> Solution.LRUCache
    else Solution.LRUCache(capacity)

test "eviction and access" (fun () ->
    let cache = make 2
    cache.Put 1 1
    cache.Put 2 2
    equal 1 (cache.Get 1)
    cache.Put 3 3
    equal -1 (cache.Get 2)
    cache.Put 4 4
    equal -1 (cache.Get 1)
    equal 3 (cache.Get 3)
    equal 4 (cache.Get 4))

test "update refreshes recency" (fun () ->
    let cache = make 2
    cache.Put 1 1
    cache.Put 2 2
    cache.Put 1 9
    cache.Put 3 3
    equal 9 (cache.Get 1)
    equal -1 (cache.Get 2))

test "capacity one" (fun () ->
    let cache = make 1
    cache.Put 1 2
    cache.Put 2 3
    equal -1 (cache.Get 1)
    equal 3 (cache.Get 2))

// Add your own cases here.

exit (finish ())
