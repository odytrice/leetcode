module ReferenceSolution

open Solution

// O(log n) insertion, O(1) median. Keeps a sorted list and reads the middle.
type ReferenceSolution() =
    inherit MedianFinder()
    let values = ResizeArray<int>()

    override _.AddNum(num) =
        let mutable low = 0
        let mutable high = values.Count
        while low < high do
            let middle = (low + high) / 2
            if values[middle] < num then low <- middle + 1 else high <- middle
        values.Insert(low, num)

    override _.FindMedian() =
        let middle = values.Count / 2
        if values.Count % 2 = 1 then float values[middle]
        else (float values[middle - 1] + float values[middle]) / 2.0
