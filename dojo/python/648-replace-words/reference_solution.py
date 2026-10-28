class ReferenceSolution:
    # O(total letters) time. Walk a trie of roots and stop at the first word end.
    def replace_words(self, dictionary: list[str], sentence: str) -> str:
        children: dict[str, dict] = {}
        ends_word: set[str] = set()
        for word in dictionary:
            node = children
            for char in word:
                node = node.setdefault(char, {})
            ends_word.add(word)

        def replace(word: str) -> str:
            node = children
            prefix = ""
            for char in word:
                if char not in node:
                    return word
                node = node[char]
                prefix += char
                if prefix in ends_word:
                    return prefix
            return word

        return " ".join(replace(word) for word in sentence.split(" "))
