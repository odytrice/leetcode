module ReferenceSolution

// O(81) time. One set of (unit kind, unit index, digit) catches repeats.
let isValidSudoku (board: char[][]) : bool =
    let seen = System.Collections.Generic.HashSet<int * int * char>()
    let mutable valid = true
    for row in 0 .. 8 do
        for column in 0 .. 8 do
            let digit = board[row][column]
            if digit <> '.' && valid then
                let box = row / 3 * 3 + column / 3
                let keys = [ (0, row, digit); (1, column, digit); (2, box, digit) ]
                if keys |> List.exists seen.Contains then
                    valid <- false
                for key in keys do
                    seen.Add key |> ignore
    valid
