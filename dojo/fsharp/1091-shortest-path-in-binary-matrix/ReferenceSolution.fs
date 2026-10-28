module ReferenceSolution

// O(n^2) time. BFS over eight neighbours finds the shortest clear path.
let shortestPathBinaryMatrix (grid: int array array) : int =
    let size = grid.Length
    if grid[0][0] <> 0 || grid[size - 1][size - 1] <> 0 then
        -1
    else
        let queue = System.Collections.Generic.Queue<int * int * int>()
        queue.Enqueue((0, 0, 1))
        grid[0][0] <- 1
        let mutable answer = -1

        while answer = -1 && queue.Count > 0 do
            let row, column, length = queue.Dequeue()
            if row = size - 1 && column = size - 1 then
                answer <- length
            else
                for rowStep in -1 .. 1 do
                    for columnStep in -1 .. 1 do
                        let nextRow = row + rowStep
                        let nextColumn = column + columnStep
                        if nextRow >= 0 && nextColumn >= 0 && nextRow < size && nextColumn < size && grid[nextRow][nextColumn] = 0 then
                            grid[nextRow][nextColumn] <- 1
                            queue.Enqueue((nextRow, nextColumn, length + 1))

        answer
