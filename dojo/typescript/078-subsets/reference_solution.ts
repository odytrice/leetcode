// O(n * 2^n) time. Each value doubles the result set by extending every subset.
export function subsets(nums: number[]): number[][] {
  const result: number[][] = [[]];
  for (const value of nums) {
    // Build the new subsets first so we do not extend the ones we are adding.
    const extended = result.map((subset) => [...subset, value]);
    result.push(...extended);
  }
  return result;
}
