module ReferenceSolution

// O(log n) time. Decides which half is sorted, then whether the target is in it.
let search (nums: int array) (target: int) : int =
    let mutable left = 0
    let mutable right = nums.Length - 1
    let mutable answer = -1

    while answer = -1 && left <= right do
        let middle = (left + right) / 2
        if nums[middle] = target then
            answer <- middle
        elif nums[left] <= nums[middle] then
            if nums[left] <= target && target < nums[middle] then
                right <- middle - 1
            else
                left <- middle + 1
        elif nums[middle] < target && target <= nums[right] then
            left <- middle + 1
        else
            right <- middle - 1

    answer
