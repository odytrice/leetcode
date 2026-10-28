#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let partitionLabels = if useReference then ReferenceSolution.partitionLabels else Solution.partitionLabels

test "example" (fun () -> sequence [ 9; 7; 8 ] (partitionLabels "ababcbacadefegdehijhklij"))
test "one part" (fun () -> sequence [ 10 ] (partitionLabels "eccbbbbdec"))
test "distinct" (fun () -> sequence [ 1; 1; 1 ] (partitionLabels "abc"))

// Add your own cases here.

exit (finish ())
