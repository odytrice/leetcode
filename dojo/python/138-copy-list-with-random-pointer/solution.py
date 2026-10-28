from __future__ import annotations


class RandomNode:
    def __init__(
        self,
        val: int = 0,
        next: RandomNode | None = None,
        random: RandomNode | None = None,
    ) -> None:
        self.val = val
        self.next = next
        self.random = random


class Solution:
    def copy_random_list(self, head: RandomNode | None) -> RandomNode | None:
        raise NotImplementedError
