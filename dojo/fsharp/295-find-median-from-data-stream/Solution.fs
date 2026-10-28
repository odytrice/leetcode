module Solution

type MedianFinder() =
    abstract AddNum : int -> unit
    default _.AddNum(_: int) = failwith "TODO: implement addNum"

    abstract FindMedian : unit -> float
    default _.FindMedian() = failwith "TODO: implement findMedian"
