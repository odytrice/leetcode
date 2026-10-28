#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let evalRPN = if useReference then ReferenceSolution.evalRPN else Solution.evalRPN

test "example" (fun () -> equal 9 (evalRPN [| "2"; "1"; "+"; "3"; "*" |]))
test "operand order" (fun () -> equal -1 (evalRPN [| "2"; "3"; "-" |]))
test "negative division" (fun () -> equal -2 (evalRPN [| "-7"; "3"; "/" |]))

// Add your own cases here.

exit (finish ())
