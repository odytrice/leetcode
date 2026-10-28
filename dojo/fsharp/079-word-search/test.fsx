#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let exist = if useReference then ReferenceSolution.exist else Solution.exist

let board () = [| "ABCE"; "SFCS"; "ADEE" |] |> Array.map (fun row -> row.ToCharArray())

test "found and restored" (fun () ->
    let grid = board ()
    equal true (exist grid "ABCCED")
    sequence [ "ABCE"; "SFCS"; "ADEE" ] (grid |> Array.map (fun row -> System.String(row))))

test "no cell reuse" (fun () -> equal false (exist (board ()) "ABCB"))
test "backtracking" (fun () -> equal true (exist (board ()) "SEE"))
test "single" (fun () -> equal true (exist [| [| 'a' |] |] "a"))

// Add your own cases here.

exit (finish ())
