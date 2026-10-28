module ReferenceSolution

// O(total characters) time. Letter counts identify each anagram group.
let groupAnagrams (strs: string array) : string list list =
    let groups = System.Collections.Generic.Dictionary<string, ResizeArray<string>>()

    for word in strs do
        let counts = Array.zeroCreate<int> 26
        for letter in word do
            counts[int letter - int 'a'] <- counts[int letter - int 'a'] + 1
        let key = counts |> Array.map string |> String.concat ","
        match groups.TryGetValue key with
        | true, group -> group.Add word
        | _ ->
            let group = ResizeArray<string>()
            group.Add word
            groups[key] <- group

    groups.Values |> Seq.map List.ofSeq |> List.ofSeq
