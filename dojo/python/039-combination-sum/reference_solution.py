class ReferenceSolution:
    # O(n^(target/min)) time. Reuse the current value by searching from the same index.
    def combination_sum(self, candidates: list[int], target: int) -> list[list[int]]:
        values = sorted(candidates)
        result: list[list[int]] = []
        path: list[int] = []

        def search(start: int, remaining: int) -> None:
            if remaining == 0:
                result.append(list(path))
                return
            for index in range(start, len(values)):
                if values[index] > remaining:
                    break
                path.append(values[index])
                search(index, remaining - values[index])
                path.pop()

        search(0, target)
        return result
