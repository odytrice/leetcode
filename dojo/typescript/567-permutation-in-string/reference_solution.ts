// O(len(s1) + len(s2)) time. Slide a fixed-width window and compare letter counts.
export function checkInclusion(s1: string, s2: string): boolean {
  if (s1.length > s2.length) return false;
  const need = new Array<number>(26).fill(0);
  const have = new Array<number>(26).fill(0);
  for (const char of s1) need[char.charCodeAt(0) - 97]++;
  for (let index = 0; index < s2.length; index++) {
    have[s2.charCodeAt(index) - 97]++;
    if (index >= s1.length) have[s2.charCodeAt(index - s1.length) - 97]--;
    if (index >= s1.length - 1 && have.every((count, i) => count === need[i])) return true;
  }
  return false;
}
