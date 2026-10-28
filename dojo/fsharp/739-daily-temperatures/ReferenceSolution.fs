module ReferenceSolution

// O(n) time. A monotonic stack holds days still waiting for a warmer day.
let dailyTemperatures (temperatures: int array) : int array =
    let answer = Array.zeroCreate<int> temperatures.Length
    let waiting = System.Collections.Generic.Stack<int>()

    for today in 0 .. temperatures.Length - 1 do
        while waiting.Count > 0 && temperatures[waiting.Peek()] < temperatures[today] do
            let earlier = waiting.Pop()
            answer[earlier] <- today - earlier
        waiting.Push today

    answer
