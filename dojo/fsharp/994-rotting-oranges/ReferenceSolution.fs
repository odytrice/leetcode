module ReferenceSolution

// O(rows * columns) time. Multi-source BFS spreads rot one minute per layer.
let orangesRotting (grid: int array array) : int =
    let rows = grid.Length
    let columns = grid[0].Length
    let rowStep = [| -1; 1; 0; 0 |]
    let columnStep = [| 0; 0; -1; 1 |]
    let mutable fresh = 0
    let queue = System.Collections.Generic.Queue<int * int>()

    for row in 0 .. rows - 1 do
        for column in 0 .. columns - 1 do
            if grid[row][column] = 1 then fresh <- fresh + 1
            elif grid[row][column] = 2 then queue.Enqueue((row, column))

    let mutable minutes = 0
    while fresh > 0 && queue.Count > 0 do
        minutes <- minutes + 1
        let nextQueue = System.Collections.Generic.Queue<int * int>()
        while queue.Count > 0 do
            let row, column = queue.Dequeue()
            for step in 0 .. 3 do
                let nextRow = row + rowStep[step]
                let nextColumn = column + columnStep[step]
                if nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns && grid[nextRow][nextColumn] = 1 then
                    grid[nextRow][nextColumn] <- 2
                    fresh <- fresh - 1
                    nextQueue.Enqueue((nextRow, nextColumn))
        while nextQueue.Count > 0 do
            queue.Enqueue(nextQueue.Dequeue())

    if fresh = 0 then minutes else -1
