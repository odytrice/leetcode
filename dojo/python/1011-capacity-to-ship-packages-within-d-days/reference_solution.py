class ReferenceSolution:
    # O(n log total weight) time. The capacity must fit the heaviest package.
    def ship_within_days(self, weights: list[int], days: int) -> int:
        left, right = max(weights), sum(weights)
        while left < right:
            capacity = (left + right) // 2
            used, load = 1, 0
            for weight in weights:
                if load + weight > capacity:
                    used += 1
                    load = 0
                load += weight
            if used <= days:
                right = capacity
            else:
                left = capacity + 1
        return left
