#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let replaceWords = if useReference then ReferenceSolution.replaceWords else Solution.replaceWords

test "example" (fun () ->
    equal "the cat was rat by the bat"
        (replaceWords [ "cat"; "bat"; "rat" ] "the cattle was rattled by the battery"))
test "shortest root" (fun () -> equal "a a b" (replaceWords [ "aaa"; "a"; "aa" ] "aaaa aa b"))
test "exact and absent" (fun () -> equal "cat dog" (replaceWords [ "cat" ] "cat dog"))

// Add your own cases here.

exit (finish ())
