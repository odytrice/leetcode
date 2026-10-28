module ReferenceSolution

open Solution

type private Node() =
    member val Children = System.Collections.Generic.Dictionary<char, Node>()
    member val EndsWord = false with get, set

// O(word length) per operation. Each node maps letters and records word ends.
type ReferenceSolution() =
    inherit Trie()
    let root = Node()

    override _.Insert(word) =
        let mutable node = root
        for letter in word do
            match node.Children.TryGetValue letter with
            | true, next -> node <- next
            | _ ->
                let next = Node()
                node.Children[letter] <- next
                node <- next
        node.EndsWord <- true

    member private _.Find(text: string) : Node option =
        let mutable node = Some root
        for letter in text do
            match node with
            | Some current ->
                node <-
                    match current.Children.TryGetValue letter with
                    | true, next -> Some next
                    | _ -> None
            | None -> ()
        node

    override this.Search(word) =
        match this.Find word with
        | Some node -> node.EndsWord
        | None -> false

    override this.StartsWith(prefix) = (this.Find prefix).IsSome
