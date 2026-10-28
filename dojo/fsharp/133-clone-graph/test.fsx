#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let cloneGraph = if useReference then ReferenceSolution.cloneGraph else Solution.cloneGraph

test "cycle and shared neighbors" (fun () ->
    let originals = [ for value in 1..3 -> Solution.GraphNode(value) ]
    for node in originals do
        node.Neighbors <- originals |> List.filter (fun other -> not (obj.ReferenceEquals(other, node)))

    let copy = (cloneGraph (Some originals[0])).Value
    let seen = System.Collections.Generic.Dictionary<int, Solution.GraphNode>()
    let queue = System.Collections.Generic.Queue<Solution.GraphNode>()
    queue.Enqueue copy
    while queue.Count > 0 do
        let node = queue.Dequeue()
        check (not (originals |> List.exists (fun original -> obj.ReferenceEquals(original, node))))
        if not (seen.ContainsKey node.Val) then
            seen[node.Val] <- node
            let original = originals[node.Val - 1]
            equal original.Neighbors.Length node.Neighbors.Length
            for neighbor in node.Neighbors do
                queue.Enqueue neighbor
    equal 3 seen.Count)

test "isolated" (fun () ->
    let node = Solution.GraphNode(1)
    let copy = (cloneGraph (Some node)).Value
    check (not (obj.ReferenceEquals(copy, node)))
    equal 1 copy.Val
    equal 0 copy.Neighbors.Length)

test "empty" (fun () -> check (cloneGraph None).IsNone)

// Add your own cases here.

exit (finish ())
