from collections import OrderedDict

from solution import LRUCache


class ReferenceSolution(LRUCache):
    # O(1) average per operation: a dictionary plus recency order.
    def __init__(self, capacity: int) -> None:
        self.capacity = capacity
        self.values: OrderedDict[int, int] = OrderedDict()

    def get(self, key: int) -> int:
        if key not in self.values:
            return -1
        self.values.move_to_end(key)
        return self.values[key]

    def put(self, key: int, value: int) -> None:
        if key in self.values:
            self.values.move_to_end(key)
        elif len(self.values) == self.capacity:
            self.values.popitem(last=False)
        self.values[key] = value
        self.values.move_to_end(key)
