module ReferenceSolution

// O(n^2) time. Dense Prim: picks the cheapest link to the growing tree.
let minCostConnectPoints (points: int array array) : int =
    let size = points.Length
    let used = Array.zeroCreate<bool> size
    let best = Array.create size System.Int32.MaxValue
    best[0] <- 0
    let mutable total = 0

    for _ in 0 .. size - 1 do
        let mutable chosen = -1
        for node in 0 .. size - 1 do
            if not used[node] && (chosen = -1 || best[node] < best[chosen]) then
                chosen <- node
        used[chosen] <- true
        total <- total + best[chosen]
        for node in 0 .. size - 1 do
            if not used[node] then
                let cost =
                    abs (points[chosen][0] - points[node][0])
                    + abs (points[chosen][1] - points[node][1])
                best[node] <- min best[node] cost

    total
