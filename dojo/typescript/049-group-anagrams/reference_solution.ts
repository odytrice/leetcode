// O(total characters) time. Letter counts identify each anagram group.
export function groupAnagrams(strs: string[]): string[][] {
  const groups = new Map<string, string[]>();
  for (const word of strs) {
    // Anagrams share the same letter counts, so the counts make a stable key.
    const counts = new Array<number>(26).fill(0);
    for (const char of word) {
      counts[char.charCodeAt(0) - 97] += 1;
    }
    // Join with commas so counts like 1,11 and 11,1 cannot collide.
    const key = counts.join(",");
    const group = groups.get(key);
    if (group) {
      group.push(word);
    } else {
      groups.set(key, [word]);
    }
  }
  return [...groups.values()];
}
