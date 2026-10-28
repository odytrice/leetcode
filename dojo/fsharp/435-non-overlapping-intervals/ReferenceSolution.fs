module ReferenceSolution

// O(n log n) time. Greedily keeps the interval that ends earliest.
let eraseOverlapIntervals (intervals: int array array) : int =
    let sorted = intervals |> Array.sortBy (fun interval -> interval[1])
    let mutable finish = System.Int64.MinValue
    let mutable kept = 0
    for interval in sorted do
        if int64 interval[0] >= finish then
            kept <- kept + 1
            finish <- int64 interval[1]
    intervals.Length - kept
