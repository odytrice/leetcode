// Assertions and reporting shared by the F# drills.

module TestSupport

open Models

let mutable private total = 0
let mutable private failed = 0

let check (condition: bool) =
    if not condition then failwith "Assertion failed"

let checkMessage (condition: bool) (message: string) =
    if not condition then failwith message

let equal (expected: 'a) (actual: 'a) =
    if not (Unchecked.equals expected actual) then
        failwith (sprintf "Expected %A, got %A" expected actual)

let near (expected: float) (actual: float) =
    if abs (expected - actual) > 1e-9 then
        failwith (sprintf "Expected %f, got %f" expected actual)

let sequence (expected: 'a seq) (actual: 'a seq) =
    let left = Seq.toList expected
    let right = Seq.toList actual
    if left <> right then
        failwith (sprintf "Expected %A, got %A" left right)

/// Compare outer order independently, while still detecting duplicated results.
let set (expected: 'a seq) (actual: 'a seq) =
    let key (value: 'a) = sprintf "%A" value
    sequence (expected |> Seq.map key |> Seq.sort) (actual |> Seq.map key |> Seq.sort)

let rows (expected: 'a list list) (actual: 'a list list) =
    let key (row: 'a list) = sprintf "%A" row
    set (expected |> List.map key) (actual |> List.map key)

let rowsSorted (expected: 'a list list) (actual: 'a list list) =
    let key (row: 'a list) = sprintf "%A" (List.sort row)
    set (expected |> List.map key) (actual |> List.map key)

let test (name: string) (run: unit -> unit) =
    total <- total + 1
    try
        run ()
        printfn "PASS: %s" name
    with error ->
        failed <- failed + 1
        printfn "FAIL: %s: %s" name error.Message

let finish () =
    printfn "\n%d/%d passed." (total - failed) total
    if failed = 0 then 0 else 1
