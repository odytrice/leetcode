module ReferenceSolution

// O(sorted products + prefix searches). Sorts once, then reads three matches per prefix.
let suggestedProducts (products: string array) (searchWord: string) : string list list =
    let ordered = Array.sort products
    [ for length in 1 .. searchWord.Length do
          let prefix = searchWord.Substring(0, length)
          yield
              ordered
              |> Array.filter (fun product -> product.StartsWith prefix)
              |> Array.truncate 3
              |> List.ofArray ]
