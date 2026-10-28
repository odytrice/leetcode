module ReferenceSolution

// O(amount * len(coins)) time. dp[total] is the fewest coins for that total.
let coinChange (coins: int array) (amount: int) : int =
    let unreachable = amount + 1
    let dp = Array.create (amount + 1) unreachable
    dp[0] <- 0
    for total in 1 .. amount do
        for coin in coins do
            if coin <= total then
                dp[total] <- min dp[total] (dp[total - coin] + 1)
    if dp[amount] <= amount then dp[amount] else -1
