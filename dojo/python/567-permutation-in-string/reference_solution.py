class ReferenceSolution:
    # O(len(s1) + len(s2)) time. Slide a fixed-width window and compare letter counts.
    def check_inclusion(self, s1: str, s2: str) -> bool:
        if len(s1) > len(s2):
            return False
        need = [0] * 26
        have = [0] * 26
        for char in s1:
            need[ord(char) - ord("a")] += 1
        for index, char in enumerate(s2):
            have[ord(char) - ord("a")] += 1
            if index >= len(s1):
                have[ord(s2[index - len(s1)]) - ord("a")] -= 1
            if index >= len(s1) - 1 and have == need:
                return True
        return False
