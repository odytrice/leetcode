module ReferenceSolution

// O(n log n) time. Always smashes the two heaviest stones.
let lastStoneWeight (stones: int array) : int =
    let heap = System.Collections.Generic.PriorityQueue<int, int>()
    for stone in stones do
        heap.Enqueue(stone, -stone)

    while heap.Count > 1 do
        let first = heap.Dequeue()
        let second = heap.Dequeue()
        if first <> second then
            heap.Enqueue(first - second, second - first)

    if heap.Count = 0 then 0 else heap.Dequeue()
