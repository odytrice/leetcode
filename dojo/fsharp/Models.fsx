// LeetCode supplies these types. Kept here so each drill compiles independently.

module Models

type ListNode(initialValue: int, initialNext: ListNode option) =
    let mutable nodeValue = initialValue
    let mutable nodeNext = initialNext

    new() = ListNode(0, None)
    new(value: int) = ListNode(value, None)

    member _.Val
        with get () = nodeValue
        and set value = nodeValue <- value

    member _.Next
        with get () = nodeNext
        and set value = nodeNext <- value

    static member From(values: int array) : ListNode =
        let mutable head: ListNode option = None
        for i in values.Length - 1 .. -1 .. 0 do
            head <- Some(ListNode(values[i], head))
        head.Value

    static member Values(head: ListNode option) : int list =
        let seen = ResizeArray<ListNode>()
        let values = ResizeArray<int>()
        let mutable node = head
        while node.IsSome do
            let current = node.Value
            let alreadySeen = seen |> Seq.exists (fun prior -> obj.ReferenceEquals(prior, current))
            if alreadySeen then failwith "Unexpected cycle in result"
            seen.Add current
            values.Add current.Val
            node <- current.Next
        List.ofSeq values

and TreeNode(initialValue: int) =
    let mutable nodeValue = initialValue
    let mutable nodeLeft: TreeNode option = None
    let mutable nodeRight: TreeNode option = None

    new() = TreeNode(0)

    member _.Val
        with get () = nodeValue
        and set value = nodeValue <- value

    member _.Left
        with get () = nodeLeft
        and set value = nodeLeft <- value

    member _.Right
        with get () = nodeRight
        and set value = nodeRight <- value

    static member From(values: int option array) : TreeNode option =
        if values.Length = 0 || values[0].IsNone then
            None
        else
            let root = TreeNode(values[0].Value)
            let queue = System.Collections.Generic.Queue<TreeNode>()
            queue.Enqueue root
            let mutable i = 1
            while queue.Count > 0 && i < values.Length do
                let node = queue.Dequeue()
                if i < values.Length && values[i].IsSome then
                    let child = TreeNode(values[i].Value)
                    node.Left <- Some child
                    queue.Enqueue child
                i <- i + 1
                if i < values.Length && values[i].IsSome then
                    let child = TreeNode(values[i].Value)
                    node.Right <- Some child
                    queue.Enqueue child
                i <- i + 1
            Some root
