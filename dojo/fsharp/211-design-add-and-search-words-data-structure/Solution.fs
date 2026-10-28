module Solution

type WordDictionary() =
    abstract AddWord : string -> unit
    default _.AddWord(_: string) = failwith "TODO: implement addWord"

    abstract Search : string -> bool
    default _.Search(_: string) = failwith "TODO: implement search"
