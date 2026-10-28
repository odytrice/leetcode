// O(n^2) time. Sort, then shrink the gap with two pointers.
export function threeSumClosest(nums: number[], target: number): number {
  const values = [...nums].sort((a, b) => a - b);
  let best = values[0] + values[1] + values[2];
  for (let first = 0; first < values.length - 2; first++) {
    let left = first + 1;
    let right = values.length - 1;
    while (left < right) {
      const total = values[first] + values[left] + values[right];
      if (Math.abs(total - target) < Math.abs(best - target)) best = total;
      if (total === target) return total;
      if (total < target) left++;
      else right--;
    }
  }
  return best;
}
