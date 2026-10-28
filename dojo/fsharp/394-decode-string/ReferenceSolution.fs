module ReferenceSolution

// O(output length) time. Recursive parse of one bracketed level.
let decodeString (s: string) : string =
    let mutable position = 0

    let rec parse () : string =
        let text = System.Text.StringBuilder()
        let mutable keepGoing = true
        while keepGoing && position < s.Length && s[position] <> ']' do
            if not (System.Char.IsDigit s[position]) then
                text.Append s[position] |> ignore
                position <- position + 1
            else
                let mutable count = 0
                while position < s.Length && System.Char.IsDigit s[position] do
                    count <- count * 10 + (int s[position] - int '0')
                    position <- position + 1
                position <- position + 1
                let inner = parse ()
                position <- position + 1
                for _ in 1..count do
                    text.Append inner |> ignore
        text.ToString()

    parse ()
