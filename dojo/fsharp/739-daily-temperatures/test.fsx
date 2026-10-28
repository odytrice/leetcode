#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let dailyTemperatures =
    if useReference then ReferenceSolution.dailyTemperatures else Solution.dailyTemperatures

test "example" (fun () ->
    sequence [ 1; 1; 4; 2; 1; 1; 0; 0 ] (dailyTemperatures [| 73; 74; 75; 71; 69; 72; 76; 73 |]))
test "increasing" (fun () -> sequence [ 1; 1; 1; 0 ] (dailyTemperatures [| 30; 40; 50; 60 |]))
test "equal temperatures" (fun () -> sequence [ 0; 0; 0 ] (dailyTemperatures [| 70; 70; 70 |]))
test "decreasing" (fun () -> sequence [ 0; 0; 0; 0 ] (dailyTemperatures [| 90; 80; 70; 60 |]))
test "visual walkthrough" (fun () -> sequence [ 3; 1; 1; 0 ] (dailyTemperatures [| 73; 71; 72; 74 |]))

// Add your own cases here.

exit (finish ())
