module Solution

type RandomizedSet() =
    abstract Insert : int -> bool
    default _.Insert(_: int) = failwith "TODO: implement insert"

    abstract Remove : int -> bool
    default _.Remove(_: int) = failwith "TODO: implement remove"

    abstract GetRandom : unit -> int
    default _.GetRandom() = failwith "TODO: implement getRandom"
