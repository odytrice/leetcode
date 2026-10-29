// O(len(s1) + len(s2)) time. Slide a fixed-width window and compare letter counts.
export function checkInclusion(s1: string, s2: string): boolean {
  if (s1.length > s2.length) {
    return false;
  }
  // need holds s1's letter counts; have holds the counts in the current window of s2.
  const need = new Array<number>(26).fill(0);
  const have = new Array<number>(26).fill(0);
  for (const char of s1) {
    need[char.charCodeAt(0) - 97] += 1;
  }
  for (let index = 0; index < s2.length; index += 1) {
    have[s2.charCodeAt(index) - 97] += 1;
    // Drop the letter that just slid out of the window.
    if (index >= s1.length) {
      have[s2.charCodeAt(index - s1.length) - 97] -= 1;
    }
    // Once the window is full width, matching counts mean it is a permutation of s1.
    if (index >= s1.length - 1 && have.every((count, i) => count === need[i])) {
      return true;
    }
  }
  return false;
}
