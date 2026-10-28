module ReferenceSolution

// O(n * 2^n) time. Sorts, then skips duplicates at the same depth.
let subsetsWithDup (nums: int array) : int list list =
    let values = Array.sort nums
    let result = ResizeArray<int list>()
    let path = ResizeArray<int>()

    let rec search (start: int) =
        result.Add(List.ofSeq path)
        let mutable index = start
        while index < values.Length do
            if index = start || values[index] <> values[index - 1] then
                path.Add values[index]
                search (index + 1)
                path.RemoveAt(path.Count - 1)
            index <- index + 1

    search 0
    List.ofSeq result
