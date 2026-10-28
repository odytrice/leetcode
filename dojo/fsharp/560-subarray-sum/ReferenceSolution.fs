module ReferenceSolution

// O(n) time and space. Counts earlier prefixes whose difference is k.
let subarraySum (nums: int array) (k: int) : int =
    let counts = System.Collections.Generic.Dictionary<int, int>()
    counts[0] <- 1
    let mutable total = 0
    let mutable answer = 0
    for value in nums do
        total <- total + value
        answer <- answer + (match counts.TryGetValue(total - k) with
                            | true, count -> count
                            | _ -> 0)
        counts[total] <- (match counts.TryGetValue(total) with
                          | true, count -> count + 1
                          | _ -> 1)
    answer
