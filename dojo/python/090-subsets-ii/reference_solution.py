class ReferenceSolution:
    # O(n * 2^n) time. Sort, then skip duplicates at the same depth.
    def subsets_with_dup(self, nums: list[int]) -> list[list[int]]:
        values = sorted(nums)
        result: list[list[int]] = []
        path: list[int] = []

        def search(start: int) -> None:
            result.append(list(path))
            for index in range(start, len(values)):
                if index > start and values[index] == values[index - 1]:
                    continue
                path.append(values[index])
                search(index + 1)
                path.pop()

        search(0)
        return result
