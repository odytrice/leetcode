from solution import Trie


class _Node:
    def __init__(self) -> None:
        self.children: dict[str, _Node] = {}
        self.ends_word = False


class ReferenceSolution(Trie):
    # O(word length) per operation. Each node maps letters and records word ends.
    def __init__(self) -> None:
        self.root = _Node()

    def insert(self, word: str) -> None:
        node = self.root
        for char in word:
            if char not in node.children:
                node.children[char] = _Node()
            node = node.children[char]
        node.ends_word = True

    def _find(self, text: str) -> _Node | None:
        node = self.root
        for char in text:
            if char not in node.children:
                return None
            node = node.children[char]
        return node

    def search(self, word: str) -> bool:
        node = self._find(word)
        return node is not None and node.ends_word

    def starts_with(self, prefix: str) -> bool:
        return self._find(prefix) is not None
