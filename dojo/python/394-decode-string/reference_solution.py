class ReferenceSolution:
    # O(output length) time. Recursive parse of one bracketed level.
    def decode_string(self, s: str) -> str:
        position = 0

        def parse() -> str:
            nonlocal position
            text: list[str] = []
            while position < len(s) and s[position] != "]":
                if not s[position].isdigit():
                    text.append(s[position])
                    position += 1
                    continue
                count = 0
                while position < len(s) and s[position].isdigit():
                    count = count * 10 + int(s[position])
                    position += 1
                position += 1
                inner = parse()
                position += 1
                text.append(inner * count)
            return "".join(text)

        return parse()
