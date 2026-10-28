module ReferenceSolution

// O(n * 2^n) time. Each value doubles the result set by extending every subset.
let subsets (nums: int array) : int list list =
    let result = ResizeArray<int list>()
    result.Add []
    for value in nums do
        let existing = result |> Seq.toList
        for subset in existing do
            result.Add(subset @ [ value ])
    List.ofSeq result
