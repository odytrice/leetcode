// O(output length) time. Recursive parse of one bracketed level.
export function decodeString(s: string): string {
  let position = 0;

  const parse = (): string => {
    let text = "";
    while (position < s.length && s[position] !== "]") {
      if (!/[0-9]/.test(s[position])) {
        text += s[position];
        position += 1;
        continue;
      }
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
