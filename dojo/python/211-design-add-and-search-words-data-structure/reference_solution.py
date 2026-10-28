from solution import WordDictionary


class _Node:
    def __init__(self) -> None:
        self.children: dict[str, _Node] = {}
        self.ends_word = False


class ReferenceSolution(WordDictionary):
    # O(word length) insert, branching search for '.'. Exact length is required.
    def __init__(self) -> None:
        self.root = _Node()

    def add_word(self, word: str) -> None:
        node = self.root
        for char in word:
            if char not in node.children:
                node.children[char] = _Node()
            node = node.children[char]
        node.ends_word = True

    def search(self, word: str) -> bool:
        def match(node: _Node, index: int) -> bool:
            if index == len(word):
                return node.ends_word
            char = word[index]
            if char == ".":
                return any(match(child, index + 1) for child in node.children.values())
            child = node.children.get(char)
            return child is not None and match(child, index + 1)

        return match(self.root, 0)
