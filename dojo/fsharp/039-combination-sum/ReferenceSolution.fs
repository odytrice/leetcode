module ReferenceSolution

// O(n^(target/min)) time. Reuses the current value by searching from the same index.
let combinationSum (candidates: int array) (target: int) : int list list =
    let values = Array.sort candidates
    let result = ResizeArray<int list>()
    let path = ResizeArray<int>()

    let rec search (start: int) (remaining: int) =
        if remaining = 0 then
            result.Add(List.ofSeq path)
        else
            let mutable index = start
            let mutable keepGoing = true
            while keepGoing && index < values.Length do
                if values[index] > remaining then
                    keepGoing <- false
                else
                    path.Add values[index]
                    search index (remaining - values[index])
                    path.RemoveAt(path.Count - 1)
                    index <- index + 1

    search 0 target
    List.ofSeq result
