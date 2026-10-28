module ReferenceSolution

// O(n) time. A part ends only when no letter in it appears later.
let partitionLabels (s: string) : int list =
    let last = Array.zeroCreate<int> 26
    for index in 0 .. s.Length - 1 do
        last[int s[index] - int 'a'] <- index
    let result = ResizeArray<int>()
    let mutable start = 0
    let mutable finish = 0
    for index in 0 .. s.Length - 1 do
        finish <- max finish last[int s[index] - int 'a']
        if index = finish then
            result.Add(finish - start + 1)
            start <- index + 1
    List.ofSeq result
