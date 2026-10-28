from bisect import bisect_left


class ReferenceSolution:
    # O(n log n) time. tails[k] is the smallest tail of an increasing run of length k + 1.
    def length_of_lis(self, nums: list[int]) -> int:
        tails: list[int] = []
        for value in nums:
            position = bisect_left(tails, value)
            if position == len(tails):
                tails.append(value)
            else:
                tails[position] = value
        return len(tails)
