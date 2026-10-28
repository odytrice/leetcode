module ReferenceSolution

// O(n log n) time. tails[k] is the smallest tail of an increasing run of length k + 1.
let lengthOfLIS (nums: int array) : int =
    let tails = ResizeArray<int>()
    for value in nums do
        let mutable low = 0
        let mutable high = tails.Count
        while low < high do
            let middle = (low + high) / 2
            if tails[middle] < value then low <- middle + 1 else high <- middle
        if low = tails.Count then tails.Add value else tails[low] <- value
    tails.Count
