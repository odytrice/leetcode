module ReferenceSolution

// O(edges log nodes) time. Dijkstra from the source; the answer is the farthest arrival.
let networkDelayTime (times: int array array) (n: int) (k: int) : int =
    let graph = Array.init (n + 1) (fun _ -> ResizeArray<int * int>())
    for edge in times do
        graph[edge[0]].Add((edge[1], edge[2]))

    let distance = Array.create (n + 1) System.Int32.MaxValue
    distance[k] <- 0
    let queue = System.Collections.Generic.PriorityQueue<int * int, int>()
    queue.Enqueue((0, k), 0)

    while queue.Count > 0 do
        let cost, node = queue.Dequeue()
        if cost = distance[node] then
            for target, weight in graph[node] do
                let next = cost + weight
                if next < distance[target] then
                    distance[target] <- next
                    queue.Enqueue((next, target), next)

    let mutable answer = 0
    for node in 1 .. n do
        answer <- max answer distance[node]
    if answer = System.Int32.MaxValue then -1 else answer
