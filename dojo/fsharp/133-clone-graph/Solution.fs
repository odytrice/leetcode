module Solution

type GraphNode(initialValue: int) =
    member val Val = initialValue with get, set
    member val Neighbors: GraphNode list = [] with get, set

let cloneGraph (node: GraphNode option) : GraphNode option =
    failwith "TODO: implement cloneGraph"
