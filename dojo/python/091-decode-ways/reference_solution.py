class ReferenceSolution:
    # O(n) time, O(1) space. Each position is reached as one digit or as a valid pair.
    def num_decodings(self, s: str) -> int:
        previous, current = 1, 0 if s[0] == "0" else 1
        for index in range(1, len(s)):
            following = 0 if s[index] == "0" else current
            pair = (ord(s[index - 1]) - ord("0")) * 10 + ord(s[index]) - ord("0")
            if 10 <= pair <= 26:
                following += previous
            previous, current = current, following
        return current
