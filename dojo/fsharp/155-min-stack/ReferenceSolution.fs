module ReferenceSolution

open Solution

// O(1) per operation. Each entry remembers the minimum at or below it.
type ReferenceSolution() =
    inherit MinStack()
    let stack = System.Collections.Generic.Stack<int * int>()

    override _.Push(value) =
        let currentMin =
            if stack.Count = 0 then value
            else min value (snd (stack.Peek()))
        stack.Push((value, currentMin))

    override _.Pop() = stack.Pop() |> ignore
    override _.Top() = fst (stack.Peek())
    override _.GetMin() = snd (stack.Peek())
