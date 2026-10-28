// O(n) time. Every closer must match the most recent opener.
export function isValid(s: string): boolean {
  const pairs = new Map<string, string>([[")", "("], ["]", "["], ["}", "{"]]);
  const stack: string[] = [];
  for (const char of s) {
    const opener = pairs.get(char);
    if (opener === undefined) stack.push(char);
    else if (stack.pop() !== opener) return false;
  }
  return stack.length === 0;
}
