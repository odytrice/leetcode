module ReferenceSolution

// O(n log n) time. Shoots at the earliest finishing balloon that is still uncovered.
let findMinArrowShots (points: int array array) : int =
    let sorted = points |> Array.sortBy (fun point -> point[1])
    let mutable arrows = 0
    let mutable finish = System.Int64.MinValue
    for point in sorted do
        if int64 point[0] > finish then
            arrows <- arrows + 1
            finish <- int64 point[1]
    arrows
