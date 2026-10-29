// O(n * 2^n) time. Sorts, then skips duplicates at the same depth.
export function subsetsWithDup(nums: number[]): number[][] {
  // Sorting puts duplicates next to each other so they are easy to skip.
  const values = [...nums].sort((a, b) => a - b);
  const result: number[][] = [];
  const path: number[] = [];

  const search = (start: number): void => {
    // Every path reached is a distinct subset.
    result.push([...path]);
    for (let index = start; index < values.length; index += 1) {
      // Using the same value twice at one depth would build the same subsets again.
      if (index > start && values[index] === values[index - 1]) {
        continue;
      }
      path.push(values[index]);
      search(index + 1);
      path.pop();
    }
  };

  search(0);
  return result;
}
