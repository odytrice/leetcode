module ReferenceSolution

// O(n) time. Pushes operands; each operator consumes the last two.
let evalRPN (tokens: string array) : int =
    let stack = System.Collections.Generic.Stack<int>()

    for token in tokens do
        match token with
        | "+" ->
            let right = stack.Pop()
            let left = stack.Pop()
            stack.Push(left + right)
        | "-" ->
            let right = stack.Pop()
            let left = stack.Pop()
            stack.Push(left - right)
        | "*" ->
            let right = stack.Pop()
            let left = stack.Pop()
            stack.Push(left * right)
        | "/" ->
            let right = stack.Pop()
            let left = stack.Pop()
            stack.Push(left / right)
        | number -> stack.Push(int number)

    stack.Pop()
