// O(n * 2^n) time. Precomputes palindromes, then cuts wherever one ends.
export function partition(s: string): string[][] {
  const size = s.length;
  const palindrome = Array.from({ length: size }, () => new Array<boolean>(size).fill(false));
  for (let start = size - 1; start >= 0; start--) {
    for (let end = start; end < size; end++) {
      if (s[start] === s[end] && (end - start < 2 || palindrome[start + 1][end - 1])) {
        palindrome[start][end] = true;
      }
    }
  }

  const result: string[][] = [];
  const path: string[] = [];
  const search = (start: number): void => {
    if (start === size) {
      result.push([...path]);
      return;
    }
    for (let end = start; end < size; end++) {
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
