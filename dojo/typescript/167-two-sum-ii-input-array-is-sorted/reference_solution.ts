// O(n) time, O(1) space. Move the wider end inward while the sum is wrong.
export function twoSum(numbers: number[], target: number): number[] {
  let left = 0;
  let right = numbers.length - 1;
  while (left < right) {
    const total = numbers[left] + numbers[right];
    if (total === target) {
      // The answer uses 1-based indices.
      return [left + 1, right + 1];
    }
    // Too small: only moving left raises the sum. Too big: only moving right lowers it.
    if (total < target) {
      left += 1;
    } else {
      right -= 1;
    }
  }
  throw new Error("No answer");
}
