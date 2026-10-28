#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findCheapestPrice =
    if useReference then ReferenceSolution.findCheapestPrice else Solution.findCheapestPrice

let flights = [| [| 0; 1; 100 |]; [| 1; 2; 100 |]; [| 0; 2; 500 |] |]

test "one stop" (fun () -> equal 200 (findCheapestPrice 3 flights 0 2 1))
test "no stops" (fun () -> equal 500 (findCheapestPrice 3 flights 0 2 0))
test "unreachable" (fun () -> equal -1 (findCheapestPrice 3 [| [| 0; 1; 100 |] |] 0 2 2))
test "cheaper route exceeds stop limit" (fun () ->
    equal 6 (findCheapestPrice 4 [| [| 0; 1; 1 |]; [| 1; 2; 1 |]; [| 2; 3; 1 |]; [| 0; 2; 5 |] |] 0 3 1))

// Add your own cases here.

exit (finish ())
