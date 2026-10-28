module ReferenceSolution

open Solution

type private Node() =
    member val Children = System.Collections.Generic.Dictionary<char, Node>()
    member val EndsWord = false with get, set

// O(word length) insert, branching search for '.'. Exact length is required.
type ReferenceSolution() =
    inherit WordDictionary()
    let root = Node()

    override _.AddWord(word) =
        let mutable node = root
        for letter in word do
            match node.Children.TryGetValue letter with
            | true, next -> node <- next
            | _ ->
                let next = Node()
                node.Children[letter] <- next
                node <- next
        node.EndsWord <- true

    member private this.Match(node: Node, word: string, index: int) : bool =
        if index = word.Length then
            node.EndsWord
        elif word[index] = '.' then
            node.Children.Values |> Seq.exists (fun child -> this.Match(child, word, index + 1))
        else
            match node.Children.TryGetValue word[index] with
            | true, child -> this.Match(child, word, index + 1)
            | _ -> false

    override this.Search(word) = this.Match(root, word, 0)
