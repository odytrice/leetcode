#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let longestCommonSubsequence =
    if useReference then ReferenceSolution.longestCommonSubsequence else Solution.longestCommonSubsequence

test "example" (fun () -> equal 3 (longestCommonSubsequence "abcde" "ace"))
test "disjoint" (fun () -> equal 0 (longestCommonSubsequence "abc" "def"))
test "repeated letters" (fun () -> equal 2 (longestCommonSubsequence "aaaa" "aa"))
test "order matters" (fun () -> equal 1 (longestCommonSubsequence "abc" "cba"))

// Add your own cases here.

exit (finish ())
