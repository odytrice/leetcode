module ReferenceSolution

// O(n) time, O(1) space. Dutch national flag: grows the 0 and 2 regions inward.
let sortColors (nums: int array) : unit =
    let mutable low = 0
    let mutable index = 0
    let mutable high = nums.Length - 1
    while index <= high do
        if nums[index] = 0 then
            let swap = nums[low]
            nums[low] <- nums[index]
            nums[index] <- swap
            low <- low + 1
            index <- index + 1
        elif nums[index] = 2 then
            let swap = nums[high]
            nums[high] <- nums[index]
            nums[index] <- swap
            high <- high - 1
        else
            index <- index + 1
