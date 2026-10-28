module ReferenceSolution

// O(log n) time. Two lower-bound searches: one for the target, one past it.
let searchRange (nums: int array) (target: int) : int array =
    let bound (upper: bool) =
        let mutable left = 0
        let mutable right = nums.Length
        while left < right do
            let middle = (left + right) / 2
            if nums[middle] < target || (upper && nums[middle] = target) then
                left <- middle + 1
            else
                right <- middle
        left

    let first = bound false
    if first = nums.Length || nums[first] <> target then
        [| -1; -1 |]
    else
        [| first; bound true - 1 |]
