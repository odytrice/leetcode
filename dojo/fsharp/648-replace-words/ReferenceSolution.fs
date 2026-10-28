module ReferenceSolution

type private Node() =
    member val Children = System.Collections.Generic.Dictionary<char, Node>()
    member val EndsWord = false with get, set

// O(total letters) time. Walks a trie of roots and stops at the first word end.
let replaceWords (dictionary: string list) (sentence: string) : string =
    let root = Node()

    for word in dictionary do
        let mutable node = root
        for letter in word do
            match node.Children.TryGetValue letter with
            | true, next -> node <- next
            | _ ->
                let next = Node()
                node.Children[letter] <- next
                node <- next
        node.EndsWord <- true

    let replace (word: string) =
        let mutable node = Some root
        let prefix = System.Text.StringBuilder()
        let mutable answer = word
        let mutable searching = true
        for letter in word do
            if searching then
                match node with
                | Some current ->
                    match current.Children.TryGetValue letter with
                    | true, next ->
                        node <- Some next
                        prefix.Append letter |> ignore
                        if next.EndsWord then
                            answer <- prefix.ToString()
                            searching <- false
                    | _ -> searching <- false
                | None -> searching <- false
        answer

    sentence.Split(' ') |> Array.map replace |> String.concat " "
