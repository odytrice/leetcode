class ReferenceSolution:
    # O(n * 2^n) time. Precompute palindromes, then cut wherever one ends.
    def partition(self, s: str) -> list[list[str]]:
        size = len(s)
        palindrome = [[False] * size for _ in range(size)]
        for start in range(size - 1, -1, -1):
            for end in range(start, size):
                palindrome[start][end] = s[start] == s[end] and (end - start < 2 or palindrome[start + 1][end - 1])

        result: list[list[str]] = []
        path: list[str] = []

        def search(start: int) -> None:
            if start == size:
                result.append(list(path))
                return
            for end in range(start, size):
                if palindrome[start][end]:
                    path.append(s[start : end + 1])
                    search(end + 1)
                    path.pop()

        search(0)
        return result
