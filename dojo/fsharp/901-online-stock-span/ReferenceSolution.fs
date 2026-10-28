module ReferenceSolution

open Solution

// Amortized O(1) per call. Drops prices no higher than today's, summing their spans.
type ReferenceSolution() =
    inherit StockSpanner()
    let stack = System.Collections.Generic.Stack<int * int>()

    override _.Next(price) =
        let mutable span = 1
        while stack.Count > 0 && fst (stack.Peek()) <= price do
            span <- span + snd (stack.Pop())
        stack.Push((price, span))
        span
