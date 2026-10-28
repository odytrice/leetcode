module ReferenceSolution

// O(n * max word length) time. dp[i] is true when the prefix of length i can be segmented.
let wordBreak (s: string) (wordDict: string list) : bool =
    let words = System.Collections.Generic.HashSet<string>(wordDict)
    let longest = wordDict |> List.map String.length |> List.fold max 0
    let dp = Array.zeroCreate<bool> (s.Length + 1)
    dp[0] <- true

    for finish in 1 .. s.Length do
        let mutable start = max 0 (finish - longest)
        while start < finish && not dp[finish] do
            if dp[start] && words.Contains(s.Substring(start, finish - start)) then
                dp[finish] <- true
            start <- start + 1

    dp[s.Length]
