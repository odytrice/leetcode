module ReferenceSolution

// O(n^2) time. Unions every connected pair and counts the remaining components.
let findCircleNum (isConnected: int array array) : int =
    let count = isConnected.Length
    let parent = Array.init count id
    let mutable components = count

    let rec find (node: int) =
        if parent[node] = node then node
        else
            parent[node] <- parent[parent[node]]
            find parent[node]

    for first in 0 .. count - 1 do
        for second in first + 1 .. count - 1 do
            if isConnected[first][second] = 1 then
                let rootFirst = find first
                let rootSecond = find second
                if rootFirst <> rootSecond then
                    parent[rootFirst] <- rootSecond
                    components <- components - 1

    components
