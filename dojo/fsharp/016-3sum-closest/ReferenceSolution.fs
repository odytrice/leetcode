module ReferenceSolution

// O(n^2) time. Sorts, then shrinks the gap with two pointers.
let threeSumClosest (nums: int array) (target: int) : int =
    let values = Array.sort nums
    let mutable best = values[0] + values[1] + values[2]
    let mutable doneSearch = false

    for first in 0 .. values.Length - 3 do
        if not doneSearch then
            let mutable left = first + 1
            let mutable right = values.Length - 1
            while left < right && not doneSearch do
                let total = values[first] + values[left] + values[right]
                if abs (total - target) < abs (best - target) then
                    best <- total
                if total = target then
                    doneSearch <- true
                elif total < target then
                    left <- left + 1
                else
                    right <- right - 1

    best
