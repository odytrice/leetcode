// O(n) time. Every closer must match the most recent opener.
export function isValid(s: string): boolean {
  // Maps each closer to the opener it needs.
  const pairs = new Map<string, string>([[")", "("], ["]", "["], ["}", "{"]]);
  const stack: string[] = [];
  for (const char of s) {
    const opener = pairs.get(char);
    // Not a closer, so it is an opener; remember it for later.
    if (opener === undefined) {
      stack.push(char);
    } else if (stack.pop() !== opener) {
      return false;
    }
  }
  // Any opener left on the stack was never closed.
  return stack.length === 0;
}
