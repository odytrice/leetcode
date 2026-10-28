module ReferenceSolution

// O(log n) time. The minimum is where the order breaks.
let findMin (nums: int array) : int =
    let mutable left = 0
    let mutable right = nums.Length - 1
    while left < right do
        let middle = (left + right) / 2
        if nums[middle] > nums[right] then
            left <- middle + 1
        else
            right <- middle
    nums[left]
