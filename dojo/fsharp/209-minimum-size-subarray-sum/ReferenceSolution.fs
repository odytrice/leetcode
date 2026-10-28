module ReferenceSolution

// O(n) time, O(1) space. Shrinks the window while it still reaches the target.
let minSubArrayLen (target: int) (nums: int array) : int =
    let mutable left = 0
    let mutable total = 0
    let mutable best = nums.Length + 1

    for right in 0 .. nums.Length - 1 do
        total <- total + nums[right]
        while total >= target do
            best <- min best (right - left + 1)
            total <- total - nums[left]
            left <- left + 1

    if best > nums.Length then 0 else best
