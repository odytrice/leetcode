module Solution

type NumArray(_nums: int array) =
    abstract SumRange : int -> int -> int
    default _.SumRange _ _ = failwith "TODO: implement sumRange"
