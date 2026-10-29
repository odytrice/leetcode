// O(n log total weight) time. The capacity must fit the heaviest package.
export function shipWithinDays(weights: number[], days: number): number {
  // The answer lies between the heaviest package and shipping everything in one day.
  let left = Math.max(...weights);
  let right = weights.reduce((total, weight) => total + weight, 0);
  while (left < right) {
    const capacity = (left + right) >> 1;
    // Simulate greedily: fill each day until the next package would overflow it.
    let used = 1;
    let load = 0;
    for (const weight of weights) {
      if (load + weight > capacity) {
        used += 1;
        load = 0;
      }
      load += weight;
    }
    // This capacity works, so the answer is at most this; otherwise it must be larger.
    if (used <= days) {
      right = capacity;
    } else {
      left = capacity + 1;
    }
  }
  return left;
}
