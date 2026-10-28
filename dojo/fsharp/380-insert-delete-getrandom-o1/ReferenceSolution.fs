module ReferenceSolution

open Solution

// O(1) average for every operation: swap the removal target with the last value.
type ReferenceSolution() =
    inherit RandomizedSet()
    let values = ResizeArray<int>()
    let positions = System.Collections.Generic.Dictionary<int, int>()

    override _.Insert(value) =
        if positions.ContainsKey value then
            false
        else
            positions[value] <- values.Count
            values.Add value
            true

    override _.Remove(value) =
        match positions.TryGetValue value with
        | false, _ -> false
        | true, position ->
            let last = values[values.Count - 1]
            values[position] <- last
            positions[last] <- position
            values.RemoveAt(values.Count - 1)
            positions.Remove value |> ignore
            true

    override _.GetRandom() =
        values[System.Random.Shared.Next(values.Count)]
