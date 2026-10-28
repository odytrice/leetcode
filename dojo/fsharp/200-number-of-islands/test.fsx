#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let numIslands = if useReference then ReferenceSolution.numIslands else Solution.numIslands

let grid (rows: string array) = rows |> Array.map (fun row -> row.ToCharArray())

test "example one" (fun () -> equal 1 (numIslands (grid [| "11110"; "11010"; "11000"; "00000" |])))
test "example two" (fun () -> equal 3 (numIslands (grid [| "11000"; "11000"; "00100"; "00011" |])))
test "diagonal cells are separate" (fun () -> equal 2 (numIslands (grid [| "10"; "01" |])))
test "all water" (fun () -> equal 0 (numIslands (grid [| "000"; "000" |])))
test "single column" (fun () -> equal 3 (numIslands (grid [| "1"; "1"; "0"; "1"; "0"; "1" |])))

// Add your own cases here.

exit (finish ())
