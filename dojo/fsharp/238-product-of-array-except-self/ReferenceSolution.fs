module ReferenceSolution

// O(n) time, O(1) extra space. Writes prefixes, then multiplies suffixes.
let productExceptSelf (nums: int array) : int array =
    let result = Array.create nums.Length 1
    let mutable prefix = 1
    let mutable suffix = 1

    for index in 0 .. nums.Length - 1 do
        result[index] <- prefix
        prefix <- prefix * nums[index]

    for index in nums.Length - 1 .. -1 .. 0 do
        result[index] <- result[index] * suffix
        suffix <- suffix * nums[index]

    result
