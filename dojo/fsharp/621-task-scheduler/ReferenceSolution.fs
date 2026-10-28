module ReferenceSolution

// O(n) time. The most frequent task sets the frame; ties add one slot each.
let leastInterval (tasks: char array) (n: int) : int =
    let counts = Array.zeroCreate<int> 26
    for task in tasks do
        counts[int task - int 'A'] <- counts[int task - int 'A'] + 1
    let most = Array.max counts
    let tied = counts |> Array.filter (fun count -> count = most) |> Array.length
    max tasks.Length ((most - 1) * (n + 1) + tied)
