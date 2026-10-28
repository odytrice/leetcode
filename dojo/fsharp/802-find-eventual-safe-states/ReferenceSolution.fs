module ReferenceSolution

// O(nodes + edges) time. Reverse Kahn's algorithm from terminal nodes.
let eventualSafeNodes (graph: int array array) : int list =
    let count = graph.Length
    let reverse = Array.init count (fun _ -> ResizeArray<int>())
    let degree = Array.zeroCreate<int> count
    for node in 0 .. count - 1 do
        degree[node] <- graph[node].Length
        for target in graph[node] do
            reverse[target].Add node

    let queue = System.Collections.Generic.Queue<int>()
    for node in 0 .. count - 1 do
        if degree[node] = 0 then queue.Enqueue node
    while queue.Count > 0 do
        let node = queue.Dequeue()
        for source in reverse[node] do
            degree[source] <- degree[source] - 1
            if degree[source] = 0 then queue.Enqueue source

    [ for node in 0 .. count - 1 do
          if degree[node] = 0 then yield node ]
