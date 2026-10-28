module ReferenceSolution

// O(n) time. Equal zeros and ones means a repeated running balance.
let findMaxLength (nums: int array) : int =
    let first = System.Collections.Generic.Dictionary<int, int>()
    first[0] <- -1
    let mutable balance = 0
    let mutable best = 0

    for index in 0 .. nums.Length - 1 do
        balance <- balance + (if nums[index] = 1 then 1 else -1)
        match first.TryGetValue balance with
        | true, start -> best <- max best (index - start)
        | _ -> first[balance] <- index

    best
