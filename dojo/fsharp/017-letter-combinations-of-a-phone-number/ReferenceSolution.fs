module ReferenceSolution

// O(4^n) time. Extends every prefix by each letter of the next digit.
let letterCombinations (digits: string) : string list =
    if digits.Length = 0 then
        []
    else
        let letters = [| ""; ""; "abc"; "def"; "ghi"; "jkl"; "mno"; "pqrs"; "tuv"; "wxyz" |]
        let mutable result = [ "" ]
        for digit in digits do
            result <-
                [ for prefix in result do
                      for letter in letters[int digit - int '0'] -> prefix + string letter ]
        result
