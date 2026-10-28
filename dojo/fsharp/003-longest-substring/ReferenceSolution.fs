module ReferenceSolution

// O(n) time. Each character's last position moves the window's left edge.
let lengthOfLongestSubstring (s: string) : int =
    let last = System.Collections.Generic.Dictionary<char, int>()
    let mutable left = 0
    let mutable best = 0

    for right in 0 .. s.Length - 1 do
        match last.TryGetValue s[right] with
        | true, previous -> left <- max left (previous + 1)
        | _ -> ()
        last[s[right]] <- right
        best <- max best (right - left + 1)

    best
