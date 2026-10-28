module ReferenceSolution

// O(n) time. A window is valid when everything but its most common letter fits in k.
let characterReplacement (s: string) (k: int) : int =
    let counts = Array.zeroCreate<int> 26
    let mutable left = 0
    let mutable best = 0
    let mutable most = 0

    for right in 0 .. s.Length - 1 do
        let index = int s[right] - int 'A'
        counts[index] <- counts[index] + 1
        most <- max most counts[index]
        while right - left + 1 - most > k do
            counts[int s[left] - int 'A'] <- counts[int s[left] - int 'A'] - 1
            left <- left + 1
        best <- max best (right - left + 1)

    best
