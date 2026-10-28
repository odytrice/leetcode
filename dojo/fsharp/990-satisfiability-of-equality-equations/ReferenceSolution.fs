module ReferenceSolution

// O(n) time. Unions equal letters, then rejects any inequality inside one set.
let equationsPossible (equations: string array) : bool =
    let parent = Array.init 26 id

    let rec find (node: int) =
        if parent[node] = node then node
        else
            parent[node] <- parent[parent[node]]
            find parent[node]

    let letter (text: string) (index: int) = int text[index] - int 'a'

    for equation in equations do
        if equation[1] = '=' then
            parent[find (letter equation 0)] <- find (letter equation 3)

    equations
    |> Array.forall (fun equation ->
        equation[1] <> '!'
        || find (letter equation 0) <> find (letter equation 3))
