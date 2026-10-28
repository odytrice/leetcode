module Solution

type Trie() =
    abstract Insert : string -> unit
    default _.Insert(_: string) = failwith "TODO: implement insert"

    abstract Search : string -> bool
    default _.Search(_: string) = failwith "TODO: implement search"

    abstract StartsWith : string -> bool
    default _.StartsWith(_: string) = failwith "TODO: implement startsWith"
