module ReferenceSolution

open Solution

// O(n) build, O(1) queries. Stores prefix sums so a range is one subtraction.
type ReferenceSolution(nums: int array) =
    inherit NumArray(nums)
    let prefix = Array.zeroCreate<int> (nums.Length + 1)

    do
        for index in 0 .. nums.Length - 1 do
            prefix[index + 1] <- prefix[index] + nums[index]

    override _.SumRange left right = prefix[right + 1] - prefix[left]
