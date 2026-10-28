module ReferenceSolution

// O(len1 * len2) time, O(len2) space. Keeps one row and the diagonal.
let longestCommonSubsequence (text1: string) (text2: string) : int =
    let dp = Array.zeroCreate<int> (text2.Length + 1)
    for first in text1 do
        let mutable diagonal = 0
        for column in 1 .. text2.Length do
            let previous = dp[column]
            dp[column] <-
                if first = text2[column - 1] then diagonal + 1
                else max dp[column] dp[column - 1]
            diagonal <- previous
    dp[text2.Length]
