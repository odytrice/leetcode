module Solution

type NumMatrix(_matrix: int array array) =
    abstract SumRegion : int -> int -> int -> int -> int
    default _.SumRegion _ _ _ _ = failwith "TODO: implement sumRegion"
