module ReferenceSolution

// O(m * n) time, O(n) space. Each cell adds its left and above neighbours.
let uniquePaths (m: int) (n: int) : int =
    let dp = Array.create n 1
    for _ in 1 .. m - 1 do
        for column in 1 .. n - 1 do
            dp[column] <- dp[column] + dp[column - 1]
    dp[n - 1]
