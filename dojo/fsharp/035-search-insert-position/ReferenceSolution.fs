module ReferenceSolution

// O(log n) time. Finds the first index whose value is not below the target.
let searchInsert (nums: int array) (target: int) : int =
    let mutable left = 0
    let mutable right = nums.Length
    while left < right do
        let middle = (left + right) / 2
        if nums[middle] < target then
            left <- middle + 1
        else
            right <- middle
    left
