module ReferenceSolution

// O(rows * columns log cells) time. Dijkstra on the maximum step along the path.
let minimumEffortPath (heights: int array array) : int =
    let rows = heights.Length
    let columns = heights[0].Length
    let effort = Array.init rows (fun _ -> Array.create columns System.Int32.MaxValue)
    effort[0][0] <- 0
    let queue = System.Collections.Generic.PriorityQueue<int * int * int, int>()
    queue.Enqueue((0, 0, 0), 0)
    let rowStep = [| -1; 1; 0; 0 |]
    let columnStep = [| 0; 0; -1; 1 |]
    let mutable answer = 0
    let mutable searching = true

    while searching && queue.Count > 0 do
        let cost, row, column = queue.Dequeue()
        if cost = effort[row][column] then
            if row = rows - 1 && column = columns - 1 then
                answer <- cost
                searching <- false
            else
                for step in 0 .. 3 do
                    let nextRow = row + rowStep[step]
                    let nextColumn = column + columnStep[step]
                    if nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns then
                        let nextCost =
                            max cost (abs (heights[nextRow][nextColumn] - heights[row][column]))
                        if nextCost < effort[nextRow][nextColumn] then
                            effort[nextRow][nextColumn] <- nextCost
                            queue.Enqueue((nextCost, nextRow, nextColumn), nextCost)

    answer
