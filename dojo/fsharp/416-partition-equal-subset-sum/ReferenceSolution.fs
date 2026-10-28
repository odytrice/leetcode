module ReferenceSolution

// O(n * sum) time, O(sum) space. Descending totals prevent reusing one number.
let canPartition (nums: int array) : bool =
    let total = Array.sum nums
    if total % 2 <> 0 then
        false
    else
        let target = total / 2
        let reachable = Array.zeroCreate<bool> (target + 1)
        reachable[0] <- true
        for value in nums do
            for subtotal in target .. -1 .. value do
                if reachable[subtotal - value] then
                    reachable[subtotal] <- true
        reachable[target]
