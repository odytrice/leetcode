class ReferenceSolution:
    # O(n) time. A part ends only when no letter in it appears later.
    def partition_labels(self, s: str) -> list[int]:
        last = {char: index for index, char in enumerate(s)}
        result: list[int] = []
        start = end = 0
        for index, char in enumerate(s):
            end = max(end, last[char])
            if index == end:
                result.append(end - start + 1)
                start = index + 1
        return result
