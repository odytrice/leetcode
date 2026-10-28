// O(n^(target/min)) time. Reuses the current value by searching from the same index.
export function combinationSum(candidates: number[], target: number): number[][] {
  const values = [...candidates].sort((a, b) => a - b);
  const result: number[][] = [];
  const path: number[] = [];

  const search = (start: number, remaining: number): void => {
    if (remaining === 0) {
      result.push([...path]);
      return;
    }
    for (let index = start; index < values.length; index++) {
      if (values[index] > remaining) break;
      path.push(values[index]);
      search(index, remaining - values[index]);
      path.pop();
    }
  };

  search(0, target);
  return result;
}
