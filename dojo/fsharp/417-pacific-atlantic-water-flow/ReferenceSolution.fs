module ReferenceSolution

// O(rows * columns) time. Floods backwards from each ocean and intersects.
let pacificAtlantic (heights: int array array) : int list list =
    let rows = heights.Length
    let columns = heights[0].Length
    let rowStep = [| -1; 1; 0; 0 |]
    let columnStep = [| 0; 0; -1; 1 |]

    let reach (pacific: bool) =
        let seen = System.Collections.Generic.HashSet<int * int>()
        let stack = System.Collections.Generic.Stack<int * int>()
        for row in 0 .. rows - 1 do
            let column = if pacific then 0 else columns - 1
            seen.Add((row, column)) |> ignore
            stack.Push((row, column))
        for column in 0 .. columns - 1 do
            let row = if pacific then 0 else rows - 1
            seen.Add((row, column)) |> ignore
            stack.Push((row, column))

        while stack.Count > 0 do
            let row, column = stack.Pop()
            for step in 0 .. 3 do
                let nextRow = row + rowStep[step]
                let nextColumn = column + columnStep[step]
                if nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns
                   && not (seen.Contains((nextRow, nextColumn)))
                   && heights[nextRow][nextColumn] >= heights[row][column] then
                    seen.Add((nextRow, nextColumn)) |> ignore
                    stack.Push((nextRow, nextColumn))
        seen

    let pacific = reach true
    let atlantic = reach false
    [ for row in 0 .. rows - 1 do
          for column in 0 .. columns - 1 do
              if pacific.Contains((row, column)) && atlantic.Contains((row, column)) then
                  yield [ row; column ] ]
