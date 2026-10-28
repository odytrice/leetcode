module ReferenceSolution

// O(n) time. Buckets values by frequency, then reads from the top.
let topKFrequent (nums: int array) (k: int) : int list =
    let counts = System.Collections.Generic.Dictionary<int, int>()
    for value in nums do
        counts[value] <- (match counts.TryGetValue value with
                          | true, count -> count + 1
                          | _ -> 1)

    let buckets = Array.init (nums.Length + 1) (fun _ -> ResizeArray<int>())
    for pair in counts do
        buckets[pair.Value].Add pair.Key

    let result = ResizeArray<int>()
    let mutable count = nums.Length
    while count > 0 && result.Count < k do
        for value in buckets[count] do
            if result.Count < k then result.Add value
        count <- count - 1

    List.ofSeq result
