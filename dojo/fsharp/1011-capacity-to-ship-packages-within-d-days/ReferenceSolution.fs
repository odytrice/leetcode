module ReferenceSolution

// O(n log total weight) time. The capacity must fit the heaviest package.
let shipWithinDays (weights: int array) (days: int) : int =
    let mutable left = Array.max weights
    let mutable right = Array.sum weights

    while left < right do
        let capacity = (left + right) / 2
        let mutable used = 1
        let mutable load = 0
        for weight in weights do
            if load + weight > capacity then
                used <- used + 1
                load <- 0
            load <- load + weight
        if used <= days then
            right <- capacity
        else
            left <- capacity + 1

    left
