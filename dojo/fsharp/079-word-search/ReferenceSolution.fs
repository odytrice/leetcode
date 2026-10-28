module ReferenceSolution

// O(rows * columns * 4^len(word)) time. Marks the current cell while searching.
let exist (board: char array array) (word: string) : bool =
    let rows = board.Length
    let columns = board[0].Length

    let rec search (row: int) (column: int) (index: int) : bool =
        if row < 0 || column < 0 || row >= rows || column >= columns || board[row][column] <> word[index] then
            false
        elif index = word.Length - 1 then
            true
        else
            let saved = board[row][column]
            board[row][column] <- '\000'
            let found =
                search (row - 1) column (index + 1)
                || search (row + 1) column (index + 1)
                || search row (column - 1) (index + 1)
                || search row (column + 1) (index + 1)
            board[row][column] <- saved
            found

    let mutable found = false
    for row in 0 .. rows - 1 do
        for column in 0 .. columns - 1 do
            if search row column 0 then found <- true
    found
