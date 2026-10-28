module ReferenceSolution

// O(len(s1) + len(s2)) time. Slides a fixed-width window and compares letter counts.
let checkInclusion (s1: string) (s2: string) : bool =
    if s1.Length > s2.Length then
        false
    else
        let need = Array.zeroCreate<int> 26
        let have = Array.zeroCreate<int> 26
        for letter in s1 do
            need[int letter - int 'a'] <- need[int letter - int 'a'] + 1
        let mutable found = false
        for index in 0 .. s2.Length - 1 do
            have[int s2[index] - int 'a'] <- have[int s2[index] - int 'a'] + 1
            if index >= s1.Length then
                have[int s2[index - s1.Length] - int 'a'] <- have[int s2[index - s1.Length] - int 'a'] - 1
            if index >= s1.Length - 1 && have = need then
                found <- true
        found
