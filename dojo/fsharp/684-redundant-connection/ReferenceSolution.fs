module ReferenceSolution

// O(n) time. Unions each edge; the first edge inside one component is the extra one.
let findRedundantConnection (edges: int array array) : int array =
    let parent = Array.init (edges.Length + 1) id

    let rec find (node: int) =
        if parent[node] = node then node
        else
            parent[node] <- parent[parent[node]]
            find parent[node]

    let mutable answer: int array = [||]
    let mutable index = 0
    while answer.Length = 0 && index < edges.Length do
        let edge = edges[index]
        let first = find edge[0]
        let second = find edge[1]
        if first = second then answer <- edge else parent[first] <- second
        index <- index + 1

    answer
