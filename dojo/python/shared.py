"""LeetCode helper types shared by the Python drills."""

from __future__ import annotations


class ListNode:
    def __init__(self, val: int = 0, next: ListNode | None = None) -> None:
        self.val = val
        self.next = next

    @classmethod
    def from_values(cls, values: list[int]) -> ListNode | None:
        head: ListNode | None = None
        for value in reversed(values):
            head = cls(value, head)
        return head

    def to_list(self) -> list[int]:
        values: list[int] = []
        seen: set[int] = set()
        node: ListNode | None = self
        while node is not None:
            if id(node) in seen:
                raise ValueError("Unexpected cycle in result")
            seen.add(id(node))
            values.append(node.val)
            node = node.next
        return values


class TreeNode:
    def __init__(
        self,
        val: int = 0,
        left: TreeNode | None = None,
        right: TreeNode | None = None,
    ) -> None:
        self.val = val
        self.left = left
        self.right = right

    @classmethod
    def from_level_order(cls, values: list[int | None]) -> TreeNode | None:
        """Build a tree from the LeetCode level-order list, with None for gaps."""
        if not values or values[0] is None:
            return None
        root = cls(values[0])
        queue = [root]
        index = 1
        head = 0
        while head < len(queue) and index < len(values):
            node = queue[head]
            head += 1
            if index < len(values) and values[index] is not None:
                node.left = cls(values[index])  # type: ignore[arg-type]
                queue.append(node.left)
            index += 1
            if index < len(values) and values[index] is not None:
                node.right = cls(values[index])  # type: ignore[arg-type]
                queue.append(node.right)
            index += 1
        return root
