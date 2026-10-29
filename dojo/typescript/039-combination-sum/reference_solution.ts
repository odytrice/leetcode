// O(n^(target/min)) time. Reuses the current value by searching from the same index.
export function combinationSum(candidates: number[], target: number): number[][] {
  // Sorting lets the loop stop as soon as a value is too big.
  const values = [...candidates].sort((a, b) => a - b);
  const result: number[][] = [];
  const path: number[] = [];

  const search = (start: number, remaining: number): void => {
    // Reaching exactly zero means path is a complete combination.
    if (remaining === 0) {
      result.push([...path]);
      return;
    }
    for (let index = start; index < values.length; index += 1) {
      // Every later value is at least as big, so none of them can fit either.
      if (values[index] > remaining) {
        break;
      }
      path.push(values[index]);
      // Pass index, not index + 1, because the same value may be used again.
      search(index, remaining - values[index]);
      path.pop();
    }
  };

  search(0, target);
  return result;
}
