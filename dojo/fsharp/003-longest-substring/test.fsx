#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let lengthOfLongestSubstring =
    if useReference then ReferenceSolution.lengthOfLongestSubstring else Solution.lengthOfLongestSubstring

test "example" (fun () -> equal 3 (lengthOfLongestSubstring "abcabcbb"))
test "repeated character" (fun () -> equal 1 (lengthOfLongestSubstring "bbbbb"))
test "window end" (fun () -> equal 3 (lengthOfLongestSubstring "pwwkew"))
test "empty" (fun () -> equal 0 (lengthOfLongestSubstring ""))
test "previous occurrence outside window" (fun () -> equal 2 (lengthOfLongestSubstring "abba"))

// Add your own cases here.

exit (finish ())
