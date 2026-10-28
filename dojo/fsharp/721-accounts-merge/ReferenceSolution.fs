module ReferenceSolution

// O(total emails log total emails) time. Unions accounts that share an email.
let accountsMerge (accounts: string list list) : string list list =
    let rows = Array.ofList accounts
    let parent = Array.init rows.Length id

    let rec find (node: int) =
        if parent[node] = node then node
        else
            parent[node] <- parent[parent[node]]
            find parent[node]

    let owner = System.Collections.Generic.Dictionary<string, int>()
    for index in 0 .. rows.Length - 1 do
        for email in List.tail rows[index] do
            match owner.TryGetValue email with
            | true, first -> parent[find index] <- find first
            | _ -> owner[email] <- index

    owner
    |> Seq.groupBy (fun pair -> find pair.Value)
    |> Seq.map (fun (root, pairs) ->
        List.head rows[root] :: (pairs |> Seq.map (fun pair -> pair.Key) |> Seq.sort |> List.ofSeq))
    |> List.ofSeq
