from collections import defaultdict


class ReferenceSolution:
    # O(total characters) time. Letter counts identify each anagram group.
    def group_anagrams(self, strs: list[str]) -> list[list[str]]:
        groups: dict[tuple[int, ...], list[str]] = defaultdict(list)
        for word in strs:
            counts = [0] * 26
            for char in word:
                counts[ord(char) - ord("a")] += 1
            groups[tuple(counts)].append(word)
        return list(groups.values())
