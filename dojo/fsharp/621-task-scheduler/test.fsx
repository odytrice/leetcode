#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let leastInterval = if useReference then ReferenceSolution.leastInterval else Solution.leastInterval

test "example" (fun () -> equal 8 (leastInterval ([| 'A'; 'A'; 'A'; 'B'; 'B'; 'B' |]) 2))
test "no cooldown" (fun () -> equal 6 (leastInterval ([| 'A'; 'A'; 'A'; 'B'; 'B'; 'B' |]) 0))
test "single type" (fun () -> equal 7 (leastInterval ([| 'A'; 'A'; 'A' |]) 2))
test "enough filler" (fun () -> equal 6 (leastInterval ([| 'A'; 'B'; 'C'; 'A'; 'B'; 'C' |]) 1))

// Add your own cases here.

exit (finish ())
