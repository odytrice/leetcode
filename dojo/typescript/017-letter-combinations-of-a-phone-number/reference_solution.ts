// O(4^n) time. Extends every prefix by each letter of the next digit.
export function letterCombinations(digits: string): string[] {
  if (digits.length === 0) {
    return [];
  }
  // letters[d] holds the letters printed on digit d; 0 and 1 have none.
  const letters = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
  // result holds every combination for the digits processed so far.
  let result = [""];
  for (const digit of digits) {
    const next: string[] = [];
    for (const prefix of result) {
      for (const letter of letters[Number(digit)]) {
        next.push(prefix + letter);
      }
    }
    result = next;
  }
  return result;
}
