module ReferenceSolution

// O(n) time, O(1) space. Moves the wider end inward while the sum is wrong.
let twoSum (numbers: int array) (target: int) : int array =
    let mutable left = 0
    let mutable right = numbers.Length - 1
    let mutable answer = Array.empty<int>

    while answer.Length = 0 && left < right do
        let total = numbers[left] + numbers[right]
        if total = target then
            answer <- [| left + 1; right + 1 |]
        elif total < target then
            left <- left + 1
        else
            right <- right - 1

    answer
