#load "../Models.fsx"
#load "../TestSupport.fsx"
#load "Solution.fs"
#load "ReferenceSolution.fs"

open Models
open TestSupport

let useReference = fsi.CommandLineArgs |> Array.contains "--reference"
let buildTree = if useReference then ReferenceSolution.buildTree else Solution.buildTree

let rec shape (node: TreeNode option) : string =
    match node with
    | None -> "#"
    | Some value -> sprintf "%d(%s,%s)" value.Val (shape value.Left) (shape value.Right)

test "example" (fun () ->
    equal
        (shape (TreeNode.From [| Some 3; Some 9; Some 20; None; None; Some 15; Some 7 |]))
        (shape (Some(buildTree [| 3; 9; 20; 15; 7 |] [| 9; 3; 15; 20; 7 |]))))
test "left chain" (fun () -> equal "3(2(1(#,#),#),#)" (shape (Some(buildTree [| 3; 2; 1 |] [| 1; 2; 3 |]))))
test "single" (fun () -> equal "-1(#,#)" (shape (Some(buildTree [| -1 |] [| -1 |]))))

// Add your own cases here.

exit (finish ())
