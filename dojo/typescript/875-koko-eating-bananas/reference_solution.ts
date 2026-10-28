// O(n log max(piles)) time. Binary search the smallest speed that finishes in time.
export function minEatingSpeed(piles: number[], h: number): number {
  let left = 1;
  let right = Math.max(...piles);
  while (left < right) {
    const speed = (left + right) >> 1;
    let hours = 0;
    for (const pile of piles) hours += Math.ceil(pile / speed);
    if (hours <= h) right = speed;
    else left = speed + 1;
  }
  return left;
}
