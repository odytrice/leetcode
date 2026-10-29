// O(n) time. A part ends only when no letter in it appears later.
export function partitionLabels(s: string): number[] {
  // Maps each letter to the last index where it appears.
  const last = new Map<string, number>();
  for (let index = 0; index < s.length; index += 1) {
    last.set(s[index], index);
  }
  const result: number[] = [];
  let start = 0;
  let end = 0;
  for (let index = 0; index < s.length; index += 1) {
    // The current part must reach at least as far as every letter inside it.
    end = Math.max(end, last.get(s[index]) as number);
    // No letter seen so far appears after this index, so the part can close here.
    if (index === end) {
      result.push(end - start + 1);
      start = index + 1;
    }
  }
  return result;
}
