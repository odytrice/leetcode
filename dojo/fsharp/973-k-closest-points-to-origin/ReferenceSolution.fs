module ReferenceSolution

// O(n log n) time. Sorting by squared distance keeps the arithmetic exact.
let kClosest (points: int array array) (k: int) : int array array =
    points
    |> Array.sortBy (fun point -> point[0] * point[0] + point[1] * point[1])
    |> Array.take k
