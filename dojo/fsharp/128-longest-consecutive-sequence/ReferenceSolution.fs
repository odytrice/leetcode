module ReferenceSolution

// O(n) time. Only starts counting at values with no predecessor.
let longestConsecutive (nums: int array) : int =
    let values = System.Collections.Generic.HashSet<int>(nums)
    let mutable best = 0
    for value in values do
        if not (values.Contains(value - 1)) then
            let mutable length = 1
            while values.Contains(value + length) do
                length <- length + 1
            best <- max best length
    best
