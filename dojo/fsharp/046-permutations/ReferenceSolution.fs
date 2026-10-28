module ReferenceSolution

// O(n * n!) time. Builds permutations by inserting each value at every position.
let permute (nums: int array) : int list list =
    let mutable result = [ [] ]
    for value in nums do
        result <-
            [ for permutation in result do
                  for position in 0 .. permutation.Length ->
                      let before = permutation |> List.take position
                      let after = permutation |> List.skip position
                      before @ [ value ] @ after ]
    result
