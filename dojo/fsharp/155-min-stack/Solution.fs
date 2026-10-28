module Solution

type MinStack() =
    abstract Push : int -> unit
    default _.Push(_: int) = failwith "TODO: implement push"

    abstract Pop : unit -> unit
    default _.Pop() = failwith "TODO: implement pop"

    abstract Top : unit -> int
    default _.Top() = failwith "TODO: implement top"

    abstract GetMin : unit -> int
    default _.GetMin() = failwith "TODO: implement getMin"
