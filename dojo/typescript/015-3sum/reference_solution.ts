// O(n^2) time. Sort, then fix one value and use two pointers.
export function threeSum(nums: number[]): number[][] {
  const values = [...nums].sort((a, b) => a - b);
  const result: number[][] = [];
  for (let first = 0; first < values.length - 2; first += 1) {
    // Skip a repeated first value so the same triplet is not reported twice.
    if (first > 0 && values[first] === values[first - 1]) {
      continue;
    }
    let left = first + 1;
    let right = values.length - 1;
    while (left < right) {
      const total = values[first] + values[left] + values[right];
      // Sorted order tells us which pointer to move: left raises the sum, right lowers it.
      if (total < 0) {
        left += 1;
      } else if (total > 0) {
        right -= 1;
      } else {
        result.push([values[first], values[left], values[right]]);
        // Step past duplicates on both sides before looking for the next pair.
        const leftValue = values[left];
        const rightValue = values[right];
        while (left < right && values[left] === leftValue) {
          left += 1;
        }
        while (left < right && values[right] === rightValue) {
          right -= 1;
        }
      }
    }
  }
  return result;
}
