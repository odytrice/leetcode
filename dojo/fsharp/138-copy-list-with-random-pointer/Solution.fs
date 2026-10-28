module Solution

type RandomNode(initialValue: int) =
    let mutable nodeValue = initialValue
    let mutable nodeNext: RandomNode option = None
    let mutable nodeRandom: RandomNode option = None

    member _.Val
        with get () = nodeValue
        and set value = nodeValue <- value

    member _.Next
        with get () = nodeNext
        and set value = nodeNext <- value

    member _.Random
        with get () = nodeRandom
        and set value = nodeRandom <- value

let copyRandomList (head: RandomNode option) : RandomNode option =
    failwith "TODO: implement copyRandomList"
