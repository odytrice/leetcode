module ReferenceSolution

// O(rows * columns) time. Marks visited land as water while flooding.
let numIslands (grid: char array array) : int =
    let rows = grid.Length
    let columns = grid[0].Length
    let rowStep = [| -1; 1; 0; 0 |]
    let columnStep = [| 0; 0; -1; 1 |]
    let mutable count = 0

    for row in 0 .. rows - 1 do
        for column in 0 .. columns - 1 do
            if grid[row][column] = '1' then
                count <- count + 1
                let stack = System.Collections.Generic.Stack<int * int>()
                stack.Push((row, column))
                grid[row][column] <- '0'
                while stack.Count > 0 do
                    let currentRow, currentColumn = stack.Pop()
                    for step in 0 .. 3 do
                        let nextRow = currentRow + rowStep[step]
                        let nextColumn = currentColumn + columnStep[step]
                        if nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns && grid[nextRow][nextColumn] = '1' then
                            grid[nextRow][nextColumn] <- '0'
                            stack.Push((nextRow, nextColumn))

    count
