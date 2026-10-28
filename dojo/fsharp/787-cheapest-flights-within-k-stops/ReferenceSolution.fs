module ReferenceSolution

// O(k * flights) time. Bellman-Ford rounds, each using at most one new edge.
let findCheapestPrice (n: int) (flights: int array array) (src: int) (dst: int) (k: int) : int =
    let mutable distance = Array.create n System.Int32.MaxValue
    distance[src] <- 0

    for _ in 0 .. k do
        let following = Array.copy distance
        for flight in flights do
            if distance[flight[0]] <> System.Int32.MaxValue then
                following[flight[1]] <-
                    min following[flight[1]] (distance[flight[0]] + flight[2])
        distance <- following

    if distance[dst] = System.Int32.MaxValue then -1 else distance[dst]
