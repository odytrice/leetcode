from solution import RandomNode


class ReferenceSolution:
    # O(n) time and space. Copy every node first, then wire the pointers.
    def copy_random_list(self, head: RandomNode | None) -> RandomNode | None:
        copies: dict[int, RandomNode] = {}
        node = head
        while node is not None:
            copies[id(node)] = RandomNode(node.val)
            node = node.next

        node = head
        while node is not None:
            copy = copies[id(node)]
            copy.next = copies[id(node.next)] if node.next is not None else None
            copy.random = copies[id(node.random)] if node.random is not None else None
            node = node.next

        return copies[id(head)] if head is not None else None
