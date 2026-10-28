module ReferenceSolution

// O(n) time. A repeated remainder means a subarray divisible by k.
let checkSubarraySum (nums: int array) (k: int) : bool =
    let first = System.Collections.Generic.Dictionary<int, int>()
    first[0] <- -1
    let mutable total = 0
    let mutable found = false

    for index in 0 .. nums.Length - 1 do
        total <- total + nums[index]
        let remainder = total % k
        match first.TryGetValue remainder with
        | true, start -> if index - start >= 2 then found <- true
        | _ -> first[remainder] <- index

    found
