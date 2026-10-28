module ReferenceSolution

// O(n) time. The window may hold at most k zeros.
let longestOnes (nums: int array) (k: int) : int =
    let mutable left = 0
    let mutable zeros = 0
    let mutable best = 0

    for right in 0 .. nums.Length - 1 do
        if nums[right] = 0 then
            zeros <- zeros + 1
        while zeros > k do
            if nums[left] = 0 then
                zeros <- zeros - 1
            left <- left + 1
        best <- max best (right - left + 1)

    best
