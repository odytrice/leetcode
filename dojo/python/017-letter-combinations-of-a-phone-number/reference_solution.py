class ReferenceSolution:
    # O(4^n) time. Extend every prefix by each letter of the next digit.
    def letter_combinations(self, digits: str) -> list[str]:
        if not digits:
            return []
        letters = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"]
        result = [""]
        for digit in digits:
            result = [prefix + letter for prefix in result for letter in letters[int(digit)]]
        return result
