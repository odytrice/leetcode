module ReferenceSolution

open Solution

// O(nodes + edges) time. Copies each node once, then relinks its neighbours.
let cloneGraph (node: GraphNode option) : GraphNode option =
    match node with
    | None -> None
    | Some start ->
        let copies = System.Collections.Generic.Dictionary<GraphNode, GraphNode>(HashIdentity.Reference)
        copies[start] <- GraphNode(start.Val)
        let queue = System.Collections.Generic.Queue<GraphNode>()
        queue.Enqueue start

        while queue.Count > 0 do
            let original = queue.Dequeue()
            for neighbor in original.Neighbors do
                if not (copies.ContainsKey neighbor) then
                    copies[neighbor] <- GraphNode(neighbor.Val)
                    queue.Enqueue neighbor
                copies[original].Neighbors <- copies[original].Neighbors @ [ copies[neighbor] ]

        Some copies[start]
