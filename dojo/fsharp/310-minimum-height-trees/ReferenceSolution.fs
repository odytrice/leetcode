module ReferenceSolution

// O(n) time. Peels leaves layer by layer; the last one or two nodes are the centres.
let findMinHeightTrees (n: int) (edges: int array array) : int list =
    if n = 1 then
        [ 0 ]
    else
        let graph = Array.init n (fun _ -> ResizeArray<int>())
        let degree = Array.zeroCreate<int> n
        for edge in edges do
            graph[edge[0]].Add edge[1]
            graph[edge[1]].Add edge[0]
            degree[edge[0]] <- degree[edge[0]] + 1
            degree[edge[1]] <- degree[edge[1]] + 1

        let mutable leaves = [ for node in 0 .. n - 1 do if degree[node] = 1 then yield node ]
        let mutable remaining = n
        while remaining > 2 do
            remaining <- remaining - leaves.Length
            let nextLeaves = ResizeArray<int>()
            for leaf in leaves do
                for neighbor in graph[leaf] do
                    degree[neighbor] <- degree[neighbor] - 1
                    if degree[neighbor] = 1 then nextLeaves.Add neighbor
            leaves <- List.ofSeq nextLeaves

        List.sort leaves
