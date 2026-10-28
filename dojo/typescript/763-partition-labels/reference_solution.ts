// O(n) time. A part ends only when no letter in it appears later.
export function partitionLabels(s: string): number[] {
  const last = new Map<string, number>();
  for (let index = 0; index < s.length; index++) last.set(s[index], index);
  const result: number[] = [];
  let start = 0;
  let end = 0;
  for (let index = 0; index < s.length; index++) {
    end = Math.max(end, last.get(s[index]) as number);
    if (index === end) {
      result.push(end - start + 1);
      start = index + 1;
    }
  }
  return result;
}
