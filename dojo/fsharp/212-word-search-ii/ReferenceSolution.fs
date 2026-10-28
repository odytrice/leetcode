module ReferenceSolution

// O(cells * 4^depth) time. Searches once over a trie of all words.
type private Node() =
    member val Children = System.Collections.Generic.Dictionary<char, Node>()
    member val Word: string option = None with get, set

let findWords (board: char array array) (words: string array) : string list =
    let root = Node()
    for word in words do
        let mutable node = root
        for letter in word do
            match node.Children.TryGetValue letter with
            | true, next -> node <- next
            | _ ->
                let next = Node()
                node.Children[letter] <- next
                node <- next
        node.Word <- Some word

    let rows = board.Length
    let columns = board[0].Length
    let result = ResizeArray<string>()

    let rec search (row: int) (column: int) (node: Node) =
        if row >= 0 && column >= 0 && row < rows && column < columns then
            let letter = board[row][column]
            match node.Children.TryGetValue letter with
            | true, child ->
                match child.Word with
                | Some word ->
                    result.Add word
                    child.Word <- None
                | None -> ()
                board[row][column] <- '\000'
                search (row - 1) column child
                search (row + 1) column child
                search row (column - 1) child
                search row (column + 1) child
                board[row][column] <- letter
            | _ -> ()

    for row in 0 .. rows - 1 do
        for column in 0 .. columns - 1 do
            search row column root

    List.ofSeq result
