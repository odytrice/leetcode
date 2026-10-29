// O(n^2) time. Sort, then shrink the gap with two pointers.
export function threeSumClosest(nums: number[], target: number): number {
  const values = [...nums].sort((a, b) => a - b);
  // Start with any valid triplet so there is always something to compare against.
  let best = values[0] + values[1] + values[2];
  for (let first = 0; first < values.length - 2; first += 1) {
    let left = first + 1;
    let right = values.length - 1;
    while (left < right) {
      const total = values[first] + values[left] + values[right];
      if (Math.abs(total - target) < Math.abs(best - target)) {
        best = total;
      }
      // An exact match cannot be beaten.
      if (total === target) {
        return total;
      }
      // Too small means we need a bigger value from the left; too big means a smaller one from the right.
      if (total < target) {
        left += 1;
      } else {
        right -= 1;
      }
    }
  }
  return best;
}
