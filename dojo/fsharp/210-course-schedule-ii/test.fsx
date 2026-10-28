#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let findOrder = if useReference then ReferenceSolution.findOrder else Solution.findOrder

let verify (courses: int) (edges: int array array) =
    let order = findOrder courses edges
    equal (List.init courses id) (Array.toList order |> List.sort)
    let positions = Array.zeroCreate<int> courses
    order |> Array.iteri (fun index course -> positions[course] <- index)
    for pair in edges do
        checkMessage (positions[pair[1]] < positions[pair[0]]) "Prerequisite order violated"

test "diamond" (fun () -> verify 4 [| [| 1; 0 |]; [| 2; 0 |]; [| 3; 1 |]; [| 3; 2 |] |])
test "cycle" (fun () -> equal 0 (findOrder 2 [| [| 1; 0 |]; [| 0; 1 |] |]).Length)
test "isolated courses" (fun () -> verify 3 [||])

// Add your own cases here.

exit (finish ())
