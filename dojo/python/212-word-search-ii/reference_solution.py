class ReferenceSolution:
    # O(cells * 4^depth) time. Search once over a trie of all words.
    def find_words(self, board: list[list[str]], words: list[str]) -> list[str]:
        children: dict[str, dict] = {}
        for word in words:
            node = children
            for char in word:
                node = node.setdefault(char, {})
            node["$"] = word

        rows, columns = len(board), len(board[0])
        result: list[str] = []

        def search(row: int, column: int, node: dict) -> None:
            if not (0 <= row < rows and 0 <= column < columns):
                return
            char = board[row][column]
            child = node.get(char)
            if child is None:
                return
            word = child.get("$")
            if word is not None:
                result.append(word)
                del child["$"]
            board[row][column] = ""
            search(row - 1, column, child)
            search(row + 1, column, child)
            search(row, column - 1, child)
            search(row, column + 1, child)
            board[row][column] = char

        for row in range(rows):
            for column in range(columns):
                search(row, column, children)
        return result
