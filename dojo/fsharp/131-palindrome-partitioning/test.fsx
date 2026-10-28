#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let partition = if useReference then ReferenceSolution.partition else Solution.partition

test "example" (fun () -> rows [ [ "a"; "a"; "b" ]; [ "aa"; "b" ] ] (partition "aab"))
test "single" (fun () -> rows [ [ "a" ] ] (partition "a"))
test "whole palindrome" (fun () -> rows [ [ "a"; "b"; "a" ]; [ "aba" ] ] (partition "aba"))

// Add your own cases here.

exit (finish ())
