module ReferenceSolution

// O(n log max(piles)) time. Binary searches the smallest speed that finishes in time.
let minEatingSpeed (piles: int array) (h: int) : int =
    let mutable left = 1
    let mutable right = Array.max piles

    while left < right do
        let speed = (left + right) / 2
        let hours =
            piles
            |> Array.sumBy (fun pile -> (int64 pile + int64 speed - 1L) / int64 speed)
        if hours <= int64 h then
            right <- speed
        else
            left <- speed + 1

    left
