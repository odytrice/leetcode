module ReferenceSolution

// O(n) time. Every closer must match the most recent opener.
let isValid (s: string) : bool =
    let stack = System.Collections.Generic.Stack<char>()
    let mutable valid = true

    for letter in s do
        match letter with
        | '(' | '[' | '{' -> stack.Push letter
        | ')' -> valid <- valid && stack.Count > 0 && stack.Pop() = '('
        | ']' -> valid <- valid && stack.Count > 0 && stack.Pop() = '['
        | _ -> valid <- valid && stack.Count > 0 && stack.Pop() = '{'

    valid && stack.Count = 0
