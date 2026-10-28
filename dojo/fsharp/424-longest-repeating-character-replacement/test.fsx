#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let characterReplacement =
    if useReference then ReferenceSolution.characterReplacement else Solution.characterReplacement

test "example" (fun () -> equal 4 (characterReplacement "AABABBA" 1))
test "whole string" (fun () -> equal 4 (characterReplacement "ABAB" 2))
test "no replacements" (fun () -> equal 2 (characterReplacement "ABBA" 0))

// Add your own cases here.

exit (finish ())
