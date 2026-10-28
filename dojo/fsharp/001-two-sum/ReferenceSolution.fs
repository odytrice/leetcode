module ReferenceSolution

// O(n) time and space. Remembers each value's index before it is needed.
let twoSum (nums: int array) (target: int) : int array =
    let seen = System.Collections.Generic.Dictionary<int, int>()

    nums
    |> Array.indexed
    |> Array.pick (fun (index, value) ->
        match seen.TryGetValue(target - value) with
        | true, partner -> Some [| partner; index |]
        | _ ->
            seen[value] <- index
            None)
