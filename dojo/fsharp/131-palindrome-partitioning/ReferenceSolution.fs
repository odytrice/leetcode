module ReferenceSolution

// O(n * 2^n) time. Precomputes palindromes, then cuts wherever one ends.
let partition (s: string) : string list list =
    let size = s.Length
    let palindrome = Array.init size (fun _ -> Array.zeroCreate<bool> size)
    for start in size - 1 .. -1 .. 0 do
        for finish in start .. size - 1 do
            palindrome[start][finish] <-
                s[start] = s[finish] && (finish - start < 2 || palindrome[start + 1][finish - 1])

    let result = ResizeArray<string list>()
    let path = ResizeArray<string>()

    let rec search (start: int) =
        if start = size then
            result.Add(List.ofSeq path)
        else
            for finish in start .. size - 1 do
                if palindrome[start][finish] then
                    path.Add(s.Substring(start, finish - start + 1))
                    search (finish + 1)
                    path.RemoveAt(path.Count - 1)

    search 0
    List.ofSeq result
