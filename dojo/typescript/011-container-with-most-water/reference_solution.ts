// O(n) time, O(1) space. Move the shorter wall inward; it can only improve.
export function maxArea(height: number[]): number {
  let left = 0;
  let right = height.length - 1;
  let best = 0;
  while (left < right) {
    best = Math.max(best, (right - left) * Math.min(height[left], height[right]));
    if (height[left] <= height[right]) left++;
    else right--;
  }
  return best;
}
