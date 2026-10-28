#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let equationsPossible =
    if useReference then ReferenceSolution.equationsPossible else Solution.equationsPossible

test "contradiction" (fun () -> equal false (equationsPossible [| "a==b"; "b!=a" |]))
test "transitive and reordered" (fun () -> equal false (equationsPossible [| "a!=c"; "a==b"; "b==c" |]))
test "consistent" (fun () -> equal true (equationsPossible [| "a==b"; "b!=c" |]))
test "self inequality" (fun () -> equal false (equationsPossible [| "a!=a" |]))

// Add your own cases here.

exit (finish ())
