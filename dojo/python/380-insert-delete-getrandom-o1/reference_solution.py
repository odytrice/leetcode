import random

from solution import RandomizedSet


class ReferenceSolution(RandomizedSet):
    # O(1) average for every operation: swap the removal target with the last value.
    def __init__(self) -> None:
        self.values: list[int] = []
        self.index: dict[int, int] = {}

    def insert(self, val: int) -> bool:
        if val in self.index:
            return False
        self.index[val] = len(self.values)
        self.values.append(val)
        return True

    def remove(self, val: int) -> bool:
        if val not in self.index:
            return False
        position = self.index[val]
        last = self.values[-1]
        self.values[position] = last
        self.index[last] = position
        self.values.pop()
        del self.index[val]
        return True

    def get_random(self) -> int:
        return random.choice(self.values)
