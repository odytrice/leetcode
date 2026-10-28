// O(output length) time. Recursive parse of one bracketed level.
export function decodeString(s: string): string {
  let position = 0;

  const parse = (): string => {
    let text = "";
    while (position < s.length && s[position] !== "]") {
      if (!/[0-9]/.test(s[position])) {
        text += s[position++];
        continue;
      }
      let count = 0;
      while (position < s.length && /[0-9]/.test(s[position])) count = count * 10 + Number(s[position++]);
      position++;
      const inner = parse();
      position++;
      text += inner.repeat(count);
    }
    return text;
  };

  return parse();
}
