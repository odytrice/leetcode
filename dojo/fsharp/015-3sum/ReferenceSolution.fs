module ReferenceSolution

// O(n^2) time. Sorts, then fixes one value and uses two pointers.
let threeSum (nums: int array) : int list list =
    let values = Array.sort nums
    let result = ResizeArray<int list>()

    for first in 0 .. values.Length - 3 do
        if first = 0 || values[first] <> values[first - 1] then
            let mutable left = first + 1
            let mutable right = values.Length - 1
            while left < right do
                let total = values[first] + values[left] + values[right]
                if total < 0 then
                    left <- left + 1
                elif total > 0 then
                    right <- right - 1
                else
                    result.Add [ values[first]; values[left]; values[right] ]
                    let leftValue = values[left]
                    let rightValue = values[right]
                    while left < right && values[left] = leftValue do
                        left <- left + 1
                    while left < right && values[right] = rightValue do
                        right <- right - 1

    List.ofSeq result
