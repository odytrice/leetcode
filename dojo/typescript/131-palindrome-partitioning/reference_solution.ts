// O(n * 2^n) time. Precomputes palindromes, then cuts wherever one ends.
export function partition(s: string): string[][] {
  const size = s.length;
  // palindrome[start][end] is true when s[start..end] reads the same both ways.
  const palindrome = Array.from({ length: size }, () => new Array<boolean>(size).fill(false));
  // Fill from the right so palindrome[start + 1][end - 1] is ready when needed.
  for (let start = size - 1; start >= 0; start -= 1) {
    for (let end = start; end < size; end += 1) {
      if (s[start] === s[end] && (end - start < 2 || palindrome[start + 1][end - 1])) {
        palindrome[start][end] = true;
      }
    }
  }

  const result: string[][] = [];
  const path: string[] = [];
  const search = (start: number): void => {
    // Reached the end of the string, so path is a full partition.
    if (start === size) {
      result.push([...path]);
      return;
    }
    for (let end = start; end < size; end += 1) {
      // Only cut here if the piece we would take is a palindrome.
      if (palindrome[start][end]) {
        path.push(s.slice(start, end + 1));
        search(end + 1);
        path.pop();
      }
    }
  };

  search(0);
  return result;
}
