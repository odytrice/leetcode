// O(n) time, O(1) space. Each position is reached as one digit or as a valid pair.
export function numDecodings(s: string): number {
  // previous and current are the decode counts for the prefixes ending two and one positions back.
  let previous = 1;
  let current = s[0] === "0" ? 0 : 1;
  for (let index = 1; index < s.length; index += 1) {
    // A non-zero digit can stand alone, extending every decoding of the prefix before it.
    let following = s[index] === "0" ? 0 : current;
    const pair = Number(s.slice(index - 1, index + 1));
    // A pair from 10 to 26 is a letter too, extending decodings that end two positions back.
    if (pair >= 10 && pair <= 26) {
      following += previous;
    }
    previous = current;
    current = following;
  }
  return current;
}
