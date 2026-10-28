module ReferenceSolution

// O(n) time, O(1) space. Each position is reached as one digit or as a valid pair.
let numDecodings (s: string) : int =
    let mutable previous = 1
    let mutable current = if s[0] = '0' then 0 else 1
    for index in 1 .. s.Length - 1 do
        let mutable following = if s[index] = '0' then 0 else current
        let pair = (int s[index - 1] - int '0') * 10 + (int s[index] - int '0')
        if pair >= 10 && pair <= 26 then
            following <- following + previous
        previous <- current
        current <- following
    current
