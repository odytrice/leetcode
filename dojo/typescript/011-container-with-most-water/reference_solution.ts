// O(n) time, O(1) space. Move the shorter wall inward; it can only improve.
export function maxArea(height: number[]): number {
  let left = 0;
  let right = height.length - 1;
  let best = 0;
  while (left < right) {
    // The area is limited by the shorter wall.
    best = Math.max(best, (right - left) * Math.min(height[left], height[right]));
    // Moving the taller wall can never help, since width shrinks and height stays capped.
    if (height[left] <= height[right]) {
      left += 1;
    } else {
      right -= 1;
    }
  }
  return best;
}
