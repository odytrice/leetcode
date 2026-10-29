// O(n * 2^n) time. Sorts, then skips duplicates at the same depth.
export function subsetsWithDup(nums: number[]): number[][] {
  const values = [...nums].sort((a, b) => a - b);
  const result: number[][] = [];
  const path: number[] = [];

  const search = (start: number): void => {
    result.push([...path]);
    for (let index = start; index < values.length; index += 1) {
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
