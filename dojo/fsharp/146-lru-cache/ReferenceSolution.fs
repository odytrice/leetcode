module ReferenceSolution

open Solution

// O(1) average per operation: a dictionary plus a recency list.
type ReferenceSolution(capacity: int) =
    inherit LRUCache(capacity)
    let values = System.Collections.Generic.Dictionary<int, int>()
    let recency = System.Collections.Generic.LinkedList<int>()

    override _.Get(key) =
        if not (values.ContainsKey key) then
            -1
        else
            recency.Remove(key) |> ignore
            recency.AddFirst key |> ignore
            values[key]

    override _.Put key value =
        if values.ContainsKey key then
            recency.Remove(key) |> ignore
        elif values.Count = capacity then
            let oldest = recency.Last.Value
            recency.RemoveLast()
            values.Remove oldest |> ignore
        values[key] <- value
        recency.AddFirst key |> ignore
