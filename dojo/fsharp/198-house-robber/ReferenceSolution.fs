module ReferenceSolution

// O(n) time, O(1) space. Each house either skips or adds to the total two back.
let rob (nums: int array) : int =
    let mutable previous = 0
    let mutable best = 0
    for value in nums do
        let next = max best (previous + value)
        previous <- best
        best <- next
    best
