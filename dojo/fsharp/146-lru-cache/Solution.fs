module Solution

type LRUCache(_capacity: int) =
    abstract Get : int -> int
    default _.Get(_: int) = failwith "TODO: implement get"

    abstract Put : int -> int -> unit
    default _.Put(_: int) (_: int) = failwith "TODO: implement put"
