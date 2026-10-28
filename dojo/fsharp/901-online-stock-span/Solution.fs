module Solution

type StockSpanner() =
    abstract Next : int -> int
    default _.Next(_: int) = failwith "TODO: implement next"
