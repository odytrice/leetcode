module ReferenceSolution

// O(n log n) time. Sorts by start, then extends or opens a new interval.
let merge (intervals: int array array) : int list list =
    let sorted = intervals |> Array.sortBy (fun interval -> interval[0])
    let result = ResizeArray<int list>()
    for interval in sorted do
        if result.Count > 0 && (List.last result[result.Count - 1]) >= interval[0] then
            let last = result[result.Count - 1]
            result[result.Count - 1] <- [ last[0]; max last[1] interval[1] ]
        else
            result.Add [ interval[0]; interval[1] ]
    List.ofSeq result
