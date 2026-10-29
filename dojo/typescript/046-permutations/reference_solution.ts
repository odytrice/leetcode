// O(n * n!) time. Builds permutations by inserting each value at every position.
export function permute(nums: number[]): number[][] {
  // result holds every permutation of the values placed so far.
  let result: number[][] = [[]];
  for (const value of nums) {
    const next: number[][] = [];
    for (const permutation of result) {
      // A permutation of length k has k + 1 slots for the new value.
      for (let position = 0; position <= permutation.length; position += 1) {
        next.push([...permutation.slice(0, position), value, ...permutation.slice(position)]);
      }
    }
    result = next;
  }
  return result;
}
