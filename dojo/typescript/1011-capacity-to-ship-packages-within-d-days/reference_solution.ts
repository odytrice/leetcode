// O(n log total weight) time. The capacity must fit the heaviest package.
export function shipWithinDays(weights: number[], days: number): number {
  let left = Math.max(...weights);
  let right = weights.reduce((total, weight) => total + weight, 0);
  while (left < right) {
    const capacity = (left + right) >> 1;
    let used = 1;
    let load = 0;
    for (const weight of weights) {
      if (load + weight > capacity) {
        used++;
        load = 0;
      }
      load += weight;
    }
    if (used <= days) right = capacity;
    else left = capacity + 1;
  }
  return left;
}
