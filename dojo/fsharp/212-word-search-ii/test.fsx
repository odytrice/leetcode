#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findWords = if useReference then ReferenceSolution.findWords else Solution.findWords

let board (rows: string array) = rows |> Array.map (fun row -> row.ToCharArray())

test "example and restored" (fun () ->
    let grid = board [| "ab"; "cd" |]
    set [ "ab"; "ac" ] (findWords grid [| "ab"; "ac"; "ad" |])
    sequence [ "ab"; "cd" ] (grid |> Array.map (fun row -> System.String(row))))

test "multiple paths one result" (fun () ->
    set [ "aa" ] (findWords (board [| "aa"; "aa" |]) [| "aa" |]))
test "prefix words and no reuse" (fun () ->
    set [ "a"; "ab" ] (findWords (board [| "ab" |]) [| "a"; "ab"; "aba" |]))

// Add your own cases here.

exit (finish ())
