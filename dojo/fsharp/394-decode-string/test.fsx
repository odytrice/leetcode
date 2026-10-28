#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let decodeString = if useReference then ReferenceSolution.decodeString else Solution.decodeString

test "nested" (fun () -> equal "accaccacc" (decodeString "3[a2[c]]"))
test "adjacent" (fun () -> equal "abcabccdcdcdef" (decodeString "2[abc]3[cd]ef"))
test "multiple digits" (fun () -> equal (String.replicate 12 "a") (decodeString "12[a]"))

// Add your own cases here.

exit (finish ())
