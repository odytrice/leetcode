// O(output length) time. Recursive parse of one bracketed level.
export function decodeString(s: string): string {
  // position is shared by every recursive call, so each one continues where the last stopped.
  let position = 0;

  const parse = (): string => {
    let text = "";
    // Read until the end of the string or the "]" that closes this level.
    while (position < s.length && s[position] !== "]") {
      // Plain letters are copied straight through.
      if (!/[0-9]/.test(s[position])) {
        text += s[position];
        position += 1;
        continue;
      }
      // Read the whole repeat count; it can have several digits.
      let count = 0;
      while (position < s.length && /[0-9]/.test(s[position])) {
        count = count * 10 + Number(s[position]);
        position += 1;
      }
      // Skip "[", parse the inside, then skip "]".
      position += 1;
      const inner = parse();
      position += 1;
      text += inner.repeat(count);
    }
    return text;
  };

  return parse();
}
