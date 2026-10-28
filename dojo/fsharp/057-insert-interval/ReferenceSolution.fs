module ReferenceSolution

// O(n) time. Copies the earlier intervals, absorbs the overlap, then copies the rest.
let insert (intervals: int array array) (newInterval: int array) : int list list =
    let result = ResizeArray<int list>()
    let mutable index = 0
    let mutable start = newInterval[0]
    let mutable finish = newInterval[1]

    let copy (interval: int array) = result.Add([ interval[0]; interval[1] ])

    while index < intervals.Length && intervals[index][1] < start do
        copy intervals[index]
        index <- index + 1

    while index < intervals.Length && intervals[index][0] <= finish do
        let current = intervals[index]
        start <- min start current[0]
        finish <- max finish current[1]
        index <- index + 1

    result.Add([ start; finish ])

    while index < intervals.Length do
        copy intervals[index]
        index <- index + 1

    List.ofSeq result
