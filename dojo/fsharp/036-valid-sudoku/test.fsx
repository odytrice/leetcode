#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let isValidSudoku = if useReference then ReferenceSolution.isValidSudoku else Solution.isValidSudoku

let emptyBoard () : char[][] = Array.init 9 (fun _ -> Array.create 9 '.')

test "empty" (fun () -> equal true (isValidSudoku (emptyBoard ())))

test "row duplicate" (fun () ->
    let board = emptyBoard ()
    board[0][0] <- '5'
    board[0][8] <- '5'
    equal false (isValidSudoku board))

test "column duplicate" (fun () ->
    let board = emptyBoard ()
    board[0][0] <- '5'
    board[8][0] <- '5'
    equal false (isValidSudoku board))

test "box duplicate" (fun () ->
    let board = emptyBoard ()
    board[0][0] <- '5'
    board[1][1] <- '5'
    equal false (isValidSudoku board))

test "separate units" (fun () ->
    let board = emptyBoard ()
    board[0][0] <- '5'
    board[4][4] <- '5'
    equal true (isValidSudoku board))

// Add your own cases here.

exit (finish ())
