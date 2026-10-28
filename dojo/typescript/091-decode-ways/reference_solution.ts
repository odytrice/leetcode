// O(n) time, O(1) space. Each position is reached as one digit or as a valid pair.
export function numDecodings(s: string): number {
  let previous = 1;
  let current = s[0] === "0" ? 0 : 1;
  for (let index = 1; index < s.length; index++) {
    let following = s[index] === "0" ? 0 : current;
    const pair = Number(s.slice(index - 1, index + 1));
    if (pair >= 10 && pair <= 26) following += previous;
    previous = current;
    current = following;
  }
  return current;
}
